using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Documents;
using Semesterprojekt_2020.Forms.Kunder;
using Semesterprojekt_2020.Forms.Medarbejere;
using Semesterprojekt_2020.Forms.Sager;

namespace Semesterprojekt_2020
{
    // Vi laver en klasse der bruges til SQL håndtering (handling)
    class SQLHandler
    {
        //Connection string sat op så den er nem at redigere
        public static string SQLserver = "den1.mssql8.gear.host";
        public static string database = "projekt2020";
        public static string brugernavn = "projekt2020";
        public static string kodeord = "Projekt2020@";
        string connectionString = "Server=" + SQLserver + ";Database=" + database + ";User Id=" + brugernavn + ";Password=" + kodeord + ";";

        // En metode til at forbinde til databasen, ret unødvendig da vi forbinder os i alle andre metoder...
        // Kunne ændres så den ikke lukker forbindelsen selv (så man caller den for at starte forbindelsen, og en anden for at lukke)
        public void ConnectToDatabase()
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
        public void RunCommand(string command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(command, connection);

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
                    return (int)dataReader.GetValue(0);

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
            for (int i = 0; i < columnNames.Length; i++)
            {
                grid.Columns[i].Name = columnNames[i];
            }



        }

        // Metode til at fylde et DataGridView med alt fra en tabel

        public object FyldDataGridView(string tabel)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT * FROM " + tabel + "";
                    SqlDataAdapter sda = new SqlDataAdapter(com);

                    DataTable dtRecord = new DataTable();
                    sda.Fill(dtRecord);
                    return dtRecord;
                }
            }
        }

        //Kunde CRUD 

        //Metode til at fylde en sagsoversigt for en kunde, med mulighed for at vælge mellem åbne og lukkede sager

        public object FyldKundeSagOversigt(int kundeNummer, string sagStatus)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT * FROM dbo.Sag WHERE KundeID =" + kundeNummer.ToString() + " AND SlutDato " + sagStatus;
                    SqlDataAdapter sda = new SqlDataAdapter(com);

                    DataTable dtRecord = new DataTable();
                    sda.Fill(dtRecord);
                    return dtRecord;
                }
            }
        }


        //Metode til at indsætte kunde i DB

        public void OpretKunde(string knavn, string kpostnr, string kbynavn, string kadr, string kemail, string ktlf)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "INSERT INTO dbo.Kunde(Navn,Postnr,Bynavn,Adresse,Email,Tlfnr) VALUES(@knavn, @kpostnr, @kbynavn, @kadr,  @kemail, @ktlf)";
                    com.Parameters.AddWithValue("@knavn", knavn);
                    com.Parameters.AddWithValue("@kpostnr", kpostnr);
                    com.Parameters.AddWithValue("@kbynavn", kbynavn);
                    com.Parameters.AddWithValue("@kadr", kadr);
                    com.Parameters.AddWithValue("@kemail", kemail);
                    com.Parameters.AddWithValue("@ktlf", ktlf);
                    con.Open();

                    int result = com.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Database fejl ved oprettelse.");
                    }
                    else
                    {
                        MessageBox.Show("Kunde oprettet");
                    }

                }

            }
        }

        //Metode til at fylde Rediger kunde siden
        public string FyldRedKunde(int kundeNummer, string kolonne)
        {
            string result = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT * FROM dbo.Kunde WHERE KundeID = " + kundeNummer.ToString();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            result += dr[kolonne].ToString();
                            break;
                        }
                        con.Close();
                        return result;
                    }
                    else
                    {
                        con.Close();
                        result += "FEJL";
                        return result;
                    }


                }
            }
        }

        //Metode til at opdatere kunde
        public void OpdaterKunde(int kundeNummer, string knavn, string kpostnr, string kbynavn, string kadr, string kemail, string ktlf)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "UPDATE dbo.Kunde SET Navn=@knavn, Postnr=@kpostnr, Bynavn=@kbynavn, Adresse=@kadr, Email=@kemail, Tlfnr=@ktlf WHERE KundeID = " + kundeNummer.ToString();
                    con.Open();
                    com.Parameters.AddWithValue("@knavn", knavn);
                    com.Parameters.AddWithValue("@kpostnr", kpostnr);
                    com.Parameters.AddWithValue("@kbynavn", kbynavn);
                    com.Parameters.AddWithValue("@kadr", kadr);
                    com.Parameters.AddWithValue("@kemail", kemail);
                    com.Parameters.AddWithValue("@ktlf", ktlf);
                    com.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(knavn + "er blever redigeret.");


                }
            }
        }

        //Slet kunde
        public void SletKunde(int kundeNummer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "DELETE from dbo.Kunde WHERE KundeID =" + kundeNummer.ToString();
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
        }


        //Kunde CRUD Slut

        //Medarbejder CRUD


        public void OpretMedarbejder(string mnavn, string madr, string mpostnr, string mbynavn, string memail, string mtlf, int stillingID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "INSERT INTO dbo.Medarbejder(Navn,Adresse,Postnr,Bynavn,Email,Tlfnr, StillingID) VALUES(@mnavn, @madr, @mpostnr, @mbynavn, @memail, @mtlf, @mstillingID)";
                    com.Parameters.AddWithValue("@mnavn", mnavn);
                    com.Parameters.AddWithValue("@madr", madr);
                    com.Parameters.AddWithValue("@mpostnr", mpostnr);
                    com.Parameters.AddWithValue("@mbynavn", mbynavn);
                    com.Parameters.AddWithValue("@memail", memail);
                    com.Parameters.AddWithValue("@mtlf", mtlf);
                    com.Parameters.AddWithValue("@mstillingID", stillingID);

                    con.Open();
                    int result = com.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Database fejl ved oprettelse.");
                    }
                    else
                    {
                        MessageBox.Show("Kunde oprettet");
                    }
                    con.Close();


                }
            }
        }

        public void TilfojUddannelse(string mnavn, string mtlf)
        {
            MessageBox.Show(FindMedID(mnavn, mtlf).ToString());
            int medID = FindMedID(mnavn, mtlf);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "INSERT INTO dbo.Uddannelser(UddID, UddNavn, MedID, Aktiv) SELECT UddID, UddNavn, " + medID + ", 0 FROM dbo.AlleUddannelser";
                    com.Parameters.AddWithValue("@medID", medID);
                    com.Parameters.AddWithValue("@aktiv", 1);

                    con.Open();
                    int result = com.ExecuteNonQuery();
                    con.Close();


                }
            }
        }

        public int FindMedID(string mnavn, string mtlf)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT MedID FROM dbo.Medarbejder WHERE Navn = " + mnavn + " AND Tlfnr = " + mtlf;
                    con.Open();
                    using (SqlDataReader read = com.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            return Convert.ToInt32(read["MedID"]);
                        }
                        return 0;
                    }


                }
            }
        }

        public void OpdaterMedarbejder(int medarbejderNummer, string mnavn, string madr, string mpostnr, string mbynavn, string memail, string mtlf, int mstillingID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "UPDATE dbo.Medarbejder SET Navn=@mnavn, Adresse=@madr, Postnr=@mpostnr, Bynavn=@mbynavn, Email=@memail, Tlfnr=@mtlf, StillingID=@mstillingID WHERE MedID = " + medarbejderNummer.ToString();
                    con.Open();
                    com.Parameters.AddWithValue("@mnavn", mnavn);
                    com.Parameters.AddWithValue("@madr", madr);
                    com.Parameters.AddWithValue("@mpostnr", mpostnr);
                    com.Parameters.AddWithValue("@mbynavn", mbynavn);
                    com.Parameters.AddWithValue("@memail", memail);
                    com.Parameters.AddWithValue("@mtlf", mtlf);
                    com.Parameters.AddWithValue("@mstillingID", mstillingID);
                    com.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(mnavn + " er blevet redigeret.");


                }
            }
        }
        //Slet kunde
        public void SletMedarbejder(int medarbejderNummer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "DELETE from dbo.Medarbejder WHERE MedID =" + medarbejderNummer.ToString();
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void FyldStillingComoBox(ComboBox comboboxNavn)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT StillingID, StillingNavn FROM dbo.Stilling";
                    DataTable dt = new DataTable();
                    SqlDataAdapter dAdapter = new SqlDataAdapter();
                    dAdapter.SelectCommand = com;
                    con.Open();
                    dAdapter.Fill(dt);
                    con.Close();
                    comboboxNavn.ValueMember = "StillingID";
                    comboboxNavn.DisplayMember = "StillingNavn";
                    comboboxNavn.DataSource = dt;
                }
            }
        }

        //Metode til at fylde Rediger medarbejder siden
        public string FyldRedMedarbejder(int medarbejderNummer, string kolonne)
        {
            string result = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT m.*, s.StillingNavn FROM dbo.Medarbejder m JOIN dbo.Stilling s ON m.StillingID = s.StillingID WHERE MedID =" + medarbejderNummer.ToString();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            result += dr[kolonne].ToString();
                            break;
                        }
                        con.Close();
                        return result;
                    }
                    else
                    {
                        con.Close();
                        result += "FEJL";
                        return result;
                    }


                }
            }
        }

        //Metode til at fylde Medarbejder_timeoversigt dataGridView
        public object FyldMedTimeoversigt(int medarbejderNummer, string fraDato, string tilDato)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT s.SagNavn, t.YdeNavn, t.AntalTimer, t.AntalKM, t.Dato FROM dbo.Sag s JOIN dbo.TimeReg t ON s.MedID = t.MedID WHERE s.MedID = " + medarbejderNummer + " AND t.Dato BETWEEN " + fraDato + " AND " + tilDato;
                    SqlDataAdapter sda = new SqlDataAdapter(com);

                    DataTable dtRecord = new DataTable();
                    sda.Fill(dtRecord);
                    return dtRecord;
                }
            }
        }
        public void FyldUddCombobox(ComboBox comboboxNavn, int aktiv, int medarbejderNummer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT a.UddID, a.UddNavn, t.Aktiv FROM dbo.AlleUddannelser a JOIN dbo.Uddannelser t ON a.UddID = t.UddID WHERE MedID = " + medarbejderNummer + " AND Aktiv = " + aktiv;
                    DataTable dt = new DataTable();
                    SqlDataAdapter dAdapter = new SqlDataAdapter();
                    dAdapter.SelectCommand = com;
                    con.Open();
                    dAdapter.Fill(dt);
                    con.Close();
                    comboboxNavn.ValueMember = "UddID";
                    comboboxNavn.DisplayMember = "UddNavn";
                    comboboxNavn.DataSource = dt;
                }
            }

        }
        public void FyldUddListbox(ListBox listboxNavn, int aktiv, int medarbejderNummer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT a.UddID, a.UddNavn, t.Aktiv FROM dbo.AlleUddannelser a JOIN dbo.Uddannelser t ON a.UddID = t.UddID WHERE MedID = " + medarbejderNummer + " AND Aktiv = " + aktiv;
                    DataTable dt = new DataTable();
                    SqlDataAdapter dAdapter = new SqlDataAdapter();
                    dAdapter.SelectCommand = com;
                    con.Open();
                    dAdapter.Fill(dt);
                    con.Close();
                    listboxNavn.ValueMember = "UddID";
                    listboxNavn.DisplayMember = "UddNavn";
                    listboxNavn.DataSource = dt;
                }
            }

        }

        public void GorInaktiv(int uddID, int medID, int aktiv)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "UPDATE dbo.Uddannelser SET Aktiv= " + aktiv + " WHERE UddID =" + uddID + " AND MedID = " + medID;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                }
            }
        }

        //CRUD Medarbejdere slut

        //CRUD Sager start

        public void OpretSag(string ssagnavn, int skundeID, int smedID, string sstartdato, string sesttimer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "INSERT INTO dbo.Sag(SagNavn,KundeID,MedID,StartDato,EstTimer) VALUES(@ssagnavn, @skundeID, @smedID, " + sstartdato + ", @sesttimer)";
                    com.Parameters.AddWithValue("@ssagnavn", ssagnavn);
                    com.Parameters.AddWithValue("@skundeID", skundeID);
                    com.Parameters.AddWithValue("@smedID", smedID);
                    com.Parameters.AddWithValue("@sesttimer", sesttimer);

                    con.Open();
                    int result = com.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Database fejl ved oprettelse.");
                    }
                    else
                    {
                        MessageBox.Show("Sag oprettet");
                    }
                    con.Close();


                }
            }
        }
        public string FyldRedSag(int sagNummer, string kolonne)
        {
            string result = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = ("SELECT s.*, k.*, k.Navn AS KundeNavn, m.Navn AS MedarbejderNavn FROM dbo.Sag s " +
                        "JOIN dbo.Kunde k ON s.KundeID = k.KundeID " +
                        "JOIN dbo.Medarbejder m ON s.MedID = m.MedID " +
                        "WHERE SagID = " + sagNummer.ToString());
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            result += dr[kolonne].ToString();
                            break;
                        }
                        con.Close();
                        return result;
                    }
                    else
                    {
                        con.Close();
                        result += "FEJL";
                        return result;
                    }


                }
            }
        }

        public object FyldValgKunde()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT KundeID, Navn FROM dbo.Kunde";
                    SqlDataAdapter sda = new SqlDataAdapter(com);

                    DataTable dtRecord = new DataTable();
                    sda.Fill(dtRecord);
                    return dtRecord;
                }
            }
        }

        public object FyldValgAdvokat()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT MedID, Navn FROM dbo.Medarbejder";
                    SqlDataAdapter sda = new SqlDataAdapter(com);

                    DataTable dtRecord = new DataTable();
                    sda.Fill(dtRecord);
                    return dtRecord;
                }
            }
        }
        public string FyldSagOversigt(int sagNummer, string kolonne)
        {
            string result = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = ("SELECT s.*, k.*, k.Navn AS KundeNavn, m.MedID, m.Navn AS MedarbejderNavn FROM dbo.Sag s " +
                        "JOIN dbo.Kunde k ON s.KundeID = k.KundeID " +
                        "JOIN dbo.Medarbejder m ON s.MedID = m.MedID " +
                        "WHERE SagID = " + sagNummer.ToString());
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            result += dr[kolonne].ToString();
                            break;
                        }
                        con.Close();
                        return result;
                    }
                    else
                    {
                        con.Close();
                        result += "FEJL";
                        return result;
                    }


                }
            }
        }

        public object FyldSagTimeOversigt(int sagNummer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT m.Navn, t.YdeNavn, t.Dato, t.AntalTimer, t.AntalKM FROM dbo.TimeReg t JOIN dbo.Medarbejder m ON t.MedID = m.MedID WHERE SagID = " + sagNummer;
                    SqlDataAdapter sda = new SqlDataAdapter(com);

                    DataTable dtRecord = new DataTable();
                    sda.Fill(dtRecord);
                    return dtRecord;

                }
            }
        }

        public void OpretTimeReg(int medID, int sagNummer, int antalTimer, int antalKM, string ynavn, string regdato)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "INSERT INTO dbo.TimeReg(MedID, SagID, AntalTimer, AntalKM, YdeNavn, Dato) VALUES(@medID, @sagNummer, @antalTimer, @antalKM, @ynavn, " + regdato+ ")";
                    com.Parameters.AddWithValue("@medID", medID);
                    com.Parameters.AddWithValue("@sagNummer", sagNummer);
                    com.Parameters.AddWithValue("@antalTimer", antalTimer);
                    com.Parameters.AddWithValue("@antalKM", antalKM);
                    com.Parameters.AddWithValue("@ynavn", ynavn);

                    con.Open();
                    int result = com.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Database fejl ved oprettelse.");
                    }
                    else
                    {
                        MessageBox.Show("Timeregistrering oprettet");
                    }
                    con.Close();


                }
            }

        }
    }
}
