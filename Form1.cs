using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Localization
{
    public partial class Form1 : Form
    {

        //string outputFolder = @"C:\Users\Apo\Downloads\Yeni klasör\Lang Package\deneme";
        //string jsonOutputFolder = @"C:\Users\Apo\Downloads\Yeni klasör\Lang Package\deneme";
        public Form1()
        {
            InitializeComponent();
        }

        // XmlToJson butonu
        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "XML dosyaları (*.xml*)|*.xml"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog { Description = "Kaydedilecek Klasörü seçin" };

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedXmlOutputFolder = folderBrowserDialog.SelectedPath;                    
                    foreach (string selectedFiles in openFileDialog.FileNames)
                    {
                        try
                        {
                            string xmlContent = File.ReadAllText(selectedFiles);
                            XmlDocument xmlDocument = new XmlDocument();
                            xmlDocument.LoadXml(xmlContent);

                            string rawJson = JsonConvert.SerializeXmlNode(xmlDocument, Newtonsoft.Json.Formatting.Indented);

                            var parsedJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(rawJson);
                            if (parsedJson.ContainsKey("?xml"))
                                parsedJson.Remove("?xml");

                            string finalJson = JsonConvert.SerializeXmlNode(xmlDocument, Newtonsoft.Json.Formatting.Indented);

                            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(selectedFiles);
                            string jsonPath = Path.Combine(selectedXmlOutputFolder, $"{fileNameWithoutExtension}.json");

                            File.WriteAllText(jsonPath, finalJson);
                            listBox.Items.Add(jsonPath);

                            // oldJson to NewJson
                            string fontInput = txtBoxFont.Text;
                            bool.TryParse(comboBoxLeftToRight.SelectedItem?.ToString(), out bool leftToRightInput);
                            double.TryParse(txtBoxVersion.Text, out double versionInput);
                            double.TryParse(txtBoxRatio.Text, out double ratioInput);

                            Dictionary<string, NewLocalization> updatedLocalizations = new Dictionary<string, NewLocalization>();

                            string oldFileContent = File.ReadAllText(jsonPath);
                            var oldJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(oldFileContent);

                            if (oldJson.TryGetValue("Localization", out var localizationObject) &&
                                localizationObject is JObject localization &&
                                localization.TryGetValue("Section", out var sectionObject) &&
                                sectionObject is JObject section &&
                                section.TryGetValue("TextKey", out var textKeyObject) &&
                                textKeyObject is JArray textKeyArray)
                            {
                                foreach (var textKeyItem in textKeyArray)
                                {
                                    var textKey = textKeyItem.ToObject<Dictionary<string, string>>();
                                    if (textKey == null || !textKey.TryGetValue("@code", out var key)) continue;

                                    foreach (var kvp in textKey)
                                    {
                                        if (kvp.Key == "@code") continue;

                                        string lang = kvp.Key;
                                        string value = kvp.Value;
                                        AddOrUpdateTranslation(updatedLocalizations, key, lang, value, fontInput, leftToRightInput, versionInput, ratioInput);
                                    }
                                }
                            }

                            foreach (var lang in updatedLocalizations.Keys)
                            {
                                string newFilePath = Path.Combine(selectedXmlOutputFolder, lang + ".json");
                                string newJson = JsonConvert.SerializeObject(updatedLocalizations[lang], Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(newFilePath, newJson);

                                listBox.Items.Add(newFilePath);
                            }
                            MessageBox.Show("JSON dosyaları başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show($"XML'den JSON'a dönüştürme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                    }
                }
                      
            }
        }

        // OldJsonToNewJson butonu
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Json dosyaları (*.json*)|*.json"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog { Description = "Kaydedilecek Klasörü seçin" };

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedJsonOutputFolder = folderBrowserDialog.SelectedPath;
                    try
                    {
                        string[] selectedFiles = openFileDialog.FileNames;

                        string fontInput = txtBoxFont.Text;
                        bool.TryParse(comboBoxLeftToRight.SelectedItem?.ToString(), out bool leftToRightInput);
                        double.TryParse(txtBoxVersion.Text, out double versionInput);
                        double.TryParse(txtBoxRatio.Text, out double ratioInput);

                        Dictionary<string, NewLocalization> updatedLocalizations = new Dictionary<string, NewLocalization>();

                        foreach (var file in selectedFiles)
                        {
                            string oldFileContent = File.ReadAllText(file);
                            var oldEntries = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(oldFileContent);

                            foreach (var entry in oldEntries)
                            {
                                foreach (var kvp in entry)
                                {
                                    if (kvp.Key == "Key") continue;
                                    string lang = kvp.Key;
                                    string value = kvp.Value;

                                    AddOrUpdateTranslation(updatedLocalizations, entry["Key"], lang, value, fontInput, leftToRightInput, versionInput, ratioInput);
                                }
                            }
                        }
                        foreach (var lang in updatedLocalizations.Keys)
                        {
                            string newFilePath = Path.Combine(selectedJsonOutputFolder, lang + ".json");
                            string newJson = JsonConvert.SerializeObject(updatedLocalizations[lang], Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(newFilePath, newJson);

                            listBox.Items.Add(newFilePath);
                        }
                        MessageBox.Show("JSON dosyaları başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Lütfen Eski Json Dosyasını Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }       

        public void AddOrUpdateTranslation(
            Dictionary<string, NewLocalization> localization,
            string key,
            string lang,
            string value,
            string font,
            bool leftToRight,
            double version,
            double ratio)
        {

            value = string.IsNullOrWhiteSpace(value) ? "" : value;

            if (!localization.ContainsKey(lang))
            {
                localization[lang] = new NewLocalization
                {
                    Font = font,
                    LeftToRight = leftToRight,
                    Version = version,
                    Ratio = ratio,
                    Lang = lang,
                    Translations = new List<OldLocalization>()
                };
            }
            localization[lang].Translations.Add(new OldLocalization
            {
                Key = key,
                Value = value,
            });

        }

        public enum TextDirection
        {
            LeftToRight,
            RightToLeft
        }
        public void txtBoxVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Geçersiz girişi engelle
            }
        }

        public void txtBoxRatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Geçersiz girişi engelle
            }
        }


    }
}
