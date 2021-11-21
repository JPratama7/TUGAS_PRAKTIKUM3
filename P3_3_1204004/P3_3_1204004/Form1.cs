using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_3_1204004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbsmouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar mouse";
            }

            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah \nIni adalah gambar mouse";
            }
        }

        private void tbsprinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar Printer";
            }

            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah \nIni adalah gambar Printer";
            }
        }

        private void tbskeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar Keyboard";
            }

            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah \nIni adalah gambar Keyboard";
            }
        }

        private void tsbScanner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar Scanner";
            }

            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah \nIni adalah gambar Scanner";
            }
        }

        private void tbsMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked)
            {
                tslKetGambar.Text = "Cocok! ini adalah gambar Monitor";
            }

            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah \nIni adalah gambar Monitor";
            }
        }
    }
}
