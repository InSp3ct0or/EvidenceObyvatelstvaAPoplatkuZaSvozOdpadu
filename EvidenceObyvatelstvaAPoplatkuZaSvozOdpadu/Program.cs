using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu.Forms;

namespace EvidenceObyvatelstvaAPoplatkuZaSvozOdpadu
{
    internal static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BytovaJednotkaForm());
        }
    }
}
