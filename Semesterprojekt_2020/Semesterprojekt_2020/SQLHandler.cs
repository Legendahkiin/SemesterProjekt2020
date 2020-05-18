﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Semesterprojekt_2020
{
    // Vi laver en klasse der bruges til SQL håndtering (handling)
    class SQLHandler
    {

        // En metode til at forbinde til databasen, ret unødvendig da vi forbinder os i alle andre metoder...
        // Kunne ændres så den ikke lukker forbindelsen selv (så man caller den for at starte forbindelsen, og en anden for at lukke)
        public void ConnectToDatabase(string connectionString)
        {
            // Vi skaber en forbindelse (using sørger for at forbindelsen lukkes "ordentligt" igen)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // vis besked, når forbindelsen er succesfuld
                MessageBox.Show("Forbindelse oprettet!");

                // luk forbindelsen for en god ordens skyld
                connection.Close();
            }
        }

        // En metode til at køre en kommando på SQL serveren. Bruges ikke rigtig af mig, da jeg ofte skal gøre "mere" end bare køre en kommando
        public void RunCommand(string command, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(command, connection);

                connection.Close();
            }
        }
        
        // Giver ALT data fra en tabel (target)
        // Hvis vi vil vise fx kunder, så er target = "kunde" -- hvis medarbejdere, så er target = "medarbejder"
        public void ReadDatabase(string target, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // selectCmd er den kommando, vi kører på SQL databasen -- 'target' er input parameter
                string selectCmd = "SELECT * FROM " + target;

                connection.Open();
                
                // Vi laver en ny SqlCommand class med kommandoen og forbindelses-string
                SqlCommand sql = new SqlCommand(selectCmd, connection);

                // Vi åbner en dataReader for at læse output
                SqlDataReader dataReader = sql.ExecuteReader();

                // Vi har en output string (så vi faktisk kan bruge det til noget)
                string output = "";

                // Læser hver linje som resultat af ovenstående SQL kommando (SELECT * FROM target)
                while (dataReader.Read())
                {
                    // en metode der udskriver hver linje i console -- ikke spørg mig hvorfor den skal castes til IDataRecord datatypen...
                    ReadSingleRow((IDataRecord)dataReader);
                }


                connection.Close();
            }
        }

        // Denne metode returnerer antallet af columns i en tabel (f.eks. kunde)
        public static int GetColumnsInTable(string target, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // vores SQL kommando igen, der udskriver antallet af columns i en tabel
                string selectCmd = @"
                    SELECT COUNT(*) 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE table_catalog = 'semesterprojekt12020'
                    AND table_name = '" + target + "'";

                connection.Open();
                
                SqlCommand sql = new SqlCommand(selectCmd, connection);

                SqlDataReader dataReader = sql.ExecuteReader();

                while (dataReader.Read())
                {
                    // og så caster vi vores resultat til en int og returner den
                    return (int) dataReader.GetValue(0);

                }

                connection.Close();
            }

            // i tilfælde af der er gået noget galt (så alle code paths har en return værdi)
            return 0;
        }

        // Udskriver til console hvad den får i input
        private static void ReadSingleRow(IDataRecord record)
        {
            Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
        }

        // Vi laver et string array som vi kan bruge til at både få:
        // 1) Antallet af columns i en tabel (fordi vi har index)
        // 2) Navnene på hver column i en tabel (vi sætter hvert indeks' værdi til column navnet)
        // Dermed kan vi nemt vise vores columns og sætte antallet af columns på én gang
        public static string[] CreateColumnArray(string target, string connectionString)
        {
            // vi laver et array, hvis størrelse vi får med den tidligere funktion
            string[] columnNames = new string[SQLHandler.GetColumnsInTable(target, connectionString)];


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // fancy SQL der får navnet på en table column
                string selectCmd = @"
                    SELECT COLUMN_NAME
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE   
                    TABLE_NAME = '" + target + "'";

                connection.Open();
                
                SqlCommand sql = new SqlCommand(selectCmd, connection);

                SqlDataReader dataReader = sql.ExecuteReader();

                // Da dataReader selv er et slags 'for-loop' bruger vi denne int til at holde styr på hvor mange gange
                // dataReader har læst en 'linje' -- ved at give den +1 til sidst i while-loopet
                // Vi har den udenfor while-loopet fordi vi ikke vil resette den hver gang vi går ind i while-loopet igen
                int iterations = 0;

                while (dataReader.Read())
                {
                    // inde i loopet bruger vi så i (da iterations åbenbart er udenfor scope / ikke kan bruges??)
                    int i = iterations;

                    // Vi sætter i-index for vores column til at være den linje, dataReader er på i denne iteration
                    columnNames[i] = dataReader.GetValue(0).ToString();

                    // og øger så i, så vi kan gå op gennem columnNames' indekser
                    iterations++;

                }

                
                connection.Close();
            }

            return columnNames;
        }

        // Denne funktion ændrer en DataGridView, således at den sætter columns i den givne DataGridView.
        public static void SetDataGridColumns(DataGridView grid, string[] columnNames)
        {
            // Antallet af columns i vores DataGridView er længden af vores array
            grid.ColumnCount = columnNames.Length;


            // og så looper vi array'et for at sætte hver column's navn til deres index-værdi
            for(int i = 0; i < columnNames.Length; i++)
            {
                grid.Columns[i].Name = columnNames[i];
            }



        }


    }
}