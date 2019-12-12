using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace PicAnalyzer
{
    public class ComponentGenerator
    {
        private GroupBox parent;
        private string yaml;
        private List<YamlControl> yamlControls;

        public ComponentGenerator(GroupBox Parent)
        {
            // constructor
            parent = Parent;
        }

        public class ParsedYaml
        {
            public List<YamlControl> controls { get; set; }
        }

        public class YamlControl
        {
            public string type { get; set; }
            public string title { get; set; }
            public string name { get; set; }
            public int key { get; set; }
            public List<YamlControl> options { get; set; }

            public Keys getKey()
            {
                switch (key)
                {
                    case 1:
                        return Keys.D1;
                    case 2:
                        return Keys.D2;
                    case 3:
                        return Keys.D3;
                    case 4:
                        return Keys.D4;
                    case 5:
                        return Keys.D5;
                    case 6:
                        return Keys.D6;
                    case 7:
                        return Keys.D7;
                    case 8:
                        return Keys.D8;
                    case 9:
                        return Keys.D9;
                    default:
                        return Keys.Attn; // placeholder key
                }
            }
        }
        
        public void ParseYamlFile(string yamlPath)
        {
            yaml = File.ReadAllText(yamlPath);
            IDeserializer deserializer = new DeserializerBuilder().Build();
            yamlControls = deserializer.Deserialize<List<YamlControl>>(yaml);
        }

        public void CreateControls()
        {
            int currentHeight = 21;
            for (int i = 0; i < yamlControls.Count; i++)
            {
                switch (yamlControls[i].type)
                {
                    case "checkbox":
                        CheckBox cb = CreateCheckBox(yamlControls[i]);
                        cb.Location = new Point(6, currentHeight);
                        parent.Controls.Add(cb);
                        currentHeight += cb.Size.Height + 6;
                        break;
                    case "radiobutton":
                        GroupBox gb = CreateRadioControl(yamlControls[i]);
                        gb.Location = new Point(6, currentHeight);
                        parent.Controls.Add(gb);
                        currentHeight += gb.Size.Height + 6;
                        break;
                    case "textfield":
                        TextBox tb = CreateTextBox(yamlControls[i]);
                        tb.Location = new Point(6, currentHeight);
                        parent.Controls.Add(tb);
                        currentHeight += tb.Size.Height + 6;
                        break;
                    default:
                        break;
                }
            }
        }

        private CheckBox CreateCheckBox(YamlControl comp)
        {
            CheckBox cbx = new CheckBox();
            cbx.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            cbx.AutoSize = true;
            cbx.BackColor = SystemColors.ControlLightLight;
            cbx.ForeColor = SystemColors.ActiveCaptionText;
            // cbx.Location = new System.Drawing.Point(6, 19); THIS NEEDS TO BE SET DYNAMICALLY
            cbx.Name = comp.name;
            cbx.Size = new Size(97, 17);
            cbx.Text = comp.title;
            cbx.UseVisualStyleBackColor = false;
            return cbx;
        }

        private TextBox CreateTextBox(YamlControl comp)
        {
            TextBox tbx = new TextBox
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                // tbx.Location = new System.Drawing.Point(6, 185);
                Multiline = true,
                Name = comp.name,
                Size = new System.Drawing.Size(165, 103)
            };
            return tbx;
        }

        private GroupBox CreateRadioControl(YamlControl comp)
        {
            GroupBox container = new GroupBox
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                Size = new System.Drawing.Size(165, 32),
                AutoSize = true,
                Name = comp.name,
                TabStop = false,
                Text = comp.title
            };

            // then, add a list of radiobutton controls starting at height 3
            int currentHeight = 21;
            for (int i = 0; i < comp.options.Count; i++)
            {
                RadioButton btn = new RadioButton
                {
                    AutoSize = true,
                    Name = comp.options[i].name,
                    Location = new Point(6, currentHeight),
                    Size = new System.Drawing.Size(34, 17),
                    TabStop = true,
                    Text = comp.options[i].title,
                    UseVisualStyleBackColor = true
                };
                currentHeight += 23;
                container.Controls.Add(btn);
            }
            
            return container;
        }

        public void RegisterShortcuts(Dictionary<Keys, Action> shortcuts)
        {
            for (int i = 0; i < yamlControls.Count; i++)
            {
                switch (yamlControls[i].type)
                {
                    case "checkbox":
                        string cbname = yamlControls[i].name;
                        shortcuts[yamlControls[i].getKey()] = () =>
                        {
                            CheckBox cb = parent.Controls.Find(cbname, true)[0] as CheckBox;
                            cb.Checked = !cb.Checked;
                        };
                        break;
                    case "radiobutton":
                        for (int j = 0; j < yamlControls[i].options.Count; j++)
                        {
                            string rbname = yamlControls[i].options[j].name;
                            shortcuts[yamlControls[i].options[j].getKey()] = () =>
                            {
                                RadioButton rb = parent.Controls.Find(rbname, true)[0] as RadioButton;
                                rb.Checked = true;
                            };
                        }
                        break;
                    case "textfield":
                        string tfname = yamlControls[i].name;
                        shortcuts[yamlControls[i].getKey()] = () =>
                        {
                            TextBox tb = parent.Controls.Find(tfname, true)[0] as TextBox;
                            tb.Focus();
                        };
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}

