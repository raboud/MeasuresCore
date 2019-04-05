using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeasureCore.WinForms
{
    public partial class Form1 : Form
    {
        private readonly ILogger<Form1> _logger;
        private readonly AppSettings _config;

        public Form1(IOptions<AppSettings> config,
                    ILogger<Form1> logger)
        {
            _logger = logger;
            _config = config.Value;
            InitializeComponent();
            _logger.LogInformation("HERE WE AREEEEEE!!!!!!!!!!!!!!!!!!!!!!!");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
