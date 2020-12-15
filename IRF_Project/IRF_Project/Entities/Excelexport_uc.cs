using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using IRF_Project.Entities;

namespace IRF_Project
{
    public partial class Excel_uc : UserControl
    {
        LeltarEntities context = new LeltarEntities();
        List<Eszkozok> Eszkozok;
        List<Valogatott> Valogatott = new List<Valogatott>();
        bool vane = false;

        //Exceles rész kezdete
        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        public Excel_uc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Eszkozok = context.Eszkozoks.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            List<string> elemek = Nemtudomhogyankellszebben(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked);
            Valogatott.Clear(); //töröljük a lista tartalmát, lehet van beragadt dolog

            vane = true;
              
            foreach (var esz in Eszkozok)
            {
                for (int i = 0; i < elemek.Count; i++)
                {
                    if (esz.Tipus == elemek[i] && numericUpDown1.Value <= esz.Besz_eve && esz.Besz_eve <= numericUpDown2.Value )
                    {
                        Valogatott uj = new Valogatott();                        
                        uj.leltari_szam = esz.Leltari_szam;
                        uj.tipus = esz.Tipus;
                        uj.mac = esz.MAC;
                        uj.besz_eve = esz.Besz_eve;
                        uj.gyarto = esz.Gyarto;

                        Valogatott.Add(uj);
                    }
                }
            }

            dataGridView1.DataSource = Valogatott.ToList();
            
        }

        static List<string> Nemtudomhogyankellszebben(bool check_1,bool check_2, bool check_3, bool check_4, bool check_5)
        {
            List<string> lista = new List<string>();
            if (check_1 == true)
            {
                lista.Add("PC");
            }
            if (check_2 == true)
            {
                lista.Add("IP telefon");
            }
            if (check_3 == true)
            {
                lista.Add("Switch");
            }
            if (check_4 == true)
            {
                lista.Add("Router");
            }
            if (check_5 == true)
            {
                lista.Add("Monitor");
            }

            return lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }

        private void CreateExcel()
        {
            if (vane == false)
            {
                MessageBox.Show("Előbb hozd létre az elől nézetet! Anélkül nem tud Excel készülni.","Export hiba");
                return;                
            }

            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                CreateTable(); // Ennek megírása a következő feladatrészben következik

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            
            string [] headers = new string[]
            {                
                "Leltári szám",
                "Típus",
                "MAC cím",
                "Beszerzés éve",
                "Gyártó"
            };

            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = headers[i];
            }

            object[,] values = new object[Valogatott.Count, headers.Length];

            int counter = 0;
            foreach (var e in Valogatott)
            {
                values[counter, 0] = e.leltari_szam;
                values[counter, 1] = e.tipus;
                values[counter, 2] = e.mac;
                values[counter, 3] = e.besz_eve;
                values[counter, 4] = e.gyarto;
                counter++;
            }

            xlSheet.get_Range(
            GetCell(2, 1),
            GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;           

            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            Excel.Range dataRange = xlSheet.get_Range(GetCell(2, 1), GetCell(counter + 2,headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            dataRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.ColumnWidth = 20; 
            //headerRange.EntireColumn.AutoFit();            
            headerRange.Interior.Color = Color.Gray;
            headerRange.Font.Color = Color.White;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);

            for (int i = 1; i < counter+2; i++)
            {
                if (i%2 == 0)
                {
                    Excel.Range parosRange = xlSheet.get_Range(GetCell(i, 1), GetCell(i, headers.Length));
                    parosRange.Interior.Color = Color.LightGray;
                }                
            }

            //FormTable();
        }

        private void FormTable()
        {
            //mégsem
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        } //koordináták meghatározása
    }
}
