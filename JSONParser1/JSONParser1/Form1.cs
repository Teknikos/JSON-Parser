using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSONParser1
{
    public partial class JSONParser : Form
    {
        public JSONParser()
        {
            InitializeComponent();
        }
        #region UI Events
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }

        private void BtnDeserialise_Click(object sender, EventArgs e)
        {
            //DebugOutput(txtInput.Text);
            deserialiseJSON(txtInput.Text);
        }
        #endregion
        #region json Function
        private void deserialiseJSON(string strJSON)
        {
            try
            {
                var jsonPerson = JsonConvert.DeserializeObject<JsonPersonSimple>(strJSON);
                DebugOutput("Here is our json object: " + jsonPerson);
                DebugOutput("Here is the name of our person: " + jsonPerson.firstname +" " + jsonPerson.lastname);

                var complexPerson = JsonConvert.DeserializeObject<JsonPersonComplex>(strJSON);
                DebugOutput($"Our person lives in: {complexPerson.address.city} on the street: {complexPerson.address.streetAddress}" );
                DebugOutput($"{complexPerson.firstname} is well versed in: ");
                foreach (var item in complexPerson.skills)
                {
                    DebugOutput(item);
                }
                DebugOutput($"{complexPerson.firstname} can be reached at: ");
                foreach (var phoneNumber in complexPerson.phoneNumbers)
                {
                    DebugOutput($"{phoneNumber.type}: {phoneNumber.number}");
                }
//             ======================================================================
//             Deserialising the JSON to Dynamic => no need to connect it to a class.
//             ======================================================================
//              var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
//              DebugOutput("Here's our JSON object: " + jPerson.ToString());
//              DebugOutput("Here's the first name: " + jPerson.name);
//              DebugOutput("Here's some skills: " + jPerson.skills);
            }
            catch (Exception e)
            {

                DebugOutput("we had a problem: " + e.Message.ToString());
            }
        }
        #endregion
        #region Debug Output
        private void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();
            }
            catch (Exception e)
            {

                System.Diagnostics.Debug.Write(e.Message.ToString() + Environment.NewLine);
            }
        }
        #endregion
    }
}
