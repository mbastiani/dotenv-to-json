using DotEnvToJson.App.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace DotEnvToJson.App
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEnvs.Text))
                return;
            var envs = new List<Env>();

            foreach (string line in TxtEnvs.Lines)
            {
                if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                {
                    var split = line.Split("=", 2);
                    var value = split[1];
                    if (value.StartsWith("'"))
                        value = value.Remove(0, 1);
                    if (value.EndsWith("'"))
                        value = value.Remove(value.Length - 1, 1);

                    envs.Add(new Env
                    {
                        Name = split[0],
                        Value = value
                    });
                }
            }

            var json = JsonSerializer.Serialize(envs, new JsonSerializerOptions { WriteIndented = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            TxtJson.Text = json;
        }
    }
}
