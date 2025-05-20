using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kurs
{
    public class Person
    {
        public int score;
        public string name;

        public Person(int v1, string v2)
        {
            this.name = v2;
            this.score = v1;
        }
        public override string ToString()
        {
            return name +" "+ score;
        }

    }
   
    public partial class Game : Form
    {
        public string name;
        
        public Game(string nam)
        {
            InitializeComponent();
            name = nam;
        }

        private void beginGame_Click(object sender, EventArgs e)
        {
            Play n = new Play(this, name);
            Hide();
            n.Show();
        }

        private void Rule_Click(object sender, EventArgs e)
        {
            Hide();
            Rule rule = new Rule(this);
            rule.Show();
        }

        private void Change_player_Click(object sender, EventArgs e)
        {
            Hide();
            Name getname = new Name();
            getname.Show();
        }

        private void Records_Click(object sender, EventArgs e)
        {
            Hide();
            Record record = new Record(this);
            record.Show();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        public void Updaterec(string nam, int score)
        {
            int k = 0;
            List<Person> records = new List<Person>();
            List<Person> sortedList;
            int s; string n;
            string path = @"C:\Users\User\Desktop\Курсовая\my_kurs\records.txt";
            using (FileStream stream = File.OpenRead (path))
            {
                int totalBytes = (int)stream.Length;
                byte[] bytes = new byte[totalBytes];
                int bytesRead = 0;

                while (bytesRead < totalBytes)
                {
                    int len = stream.Read(bytes, bytesRead, totalBytes);
                    bytesRead += len;
                }
                string text = Encoding.UTF8.GetString(bytes);
                if (text.Length > 0)
                {
                    foreach (var item in text.Split('\n'))
                    {
                        n = item.Split(' ')[0];
                        int.TryParse(item.Split(' ')[1], out s);
                        records.Add(new Person(s, n));
                        k++;
                    }
                }
                records.Add(new Person(score, nam));
                k++;
                sortedList = records.OrderByDescending(x => x.score).ToList();
                stream.Close();
            }

            using (StreamWriter writetext = new StreamWriter("C:\\Users\\User\\Desktop\\Курсовая\\my_kurs\\records.txt", false))
            {
                int i = 0;
                foreach (var data in sortedList)
                {
                    if (sortedList.Count == 1)
                        writetext.Write(data);
                    else
                    {
                        i++;
                        if (i < k && i < 10)
                            writetext.WriteLine(data);
                        if (i == k || i == 10)
                            writetext.Write(data);
                        if (i > 10)
                            break;
                    }
                }
                writetext.Close();
            }
            new Game(nam);
        }
    }
}
