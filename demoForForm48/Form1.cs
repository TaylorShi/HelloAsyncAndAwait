using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoForForm48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e)
        {
            Init();
            await InitAsync();
            base.OnLoad(e);
        }

        private void Init()
        {
            Console.WriteLine("123");
        }

        private async Task InitAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("123");
            });
        }
    }
}
