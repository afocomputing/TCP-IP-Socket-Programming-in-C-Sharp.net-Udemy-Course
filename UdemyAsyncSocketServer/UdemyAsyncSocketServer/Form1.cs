﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LahoreSocketAsync;

namespace UdemyAsyncSocketServer
{
    public partial class Form1 : Form
    {
        LahoreSocketServer mServer;

        public Form1()
        {
            InitializeComponent();
            mServer = new LahoreSocketServer();
        }

        private void btnAcceptIncomingAsync_Click(object sender, EventArgs e)
        {
            mServer.StartListeningForIncomingConnection();
        }
    }
}
