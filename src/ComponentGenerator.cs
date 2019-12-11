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
            public List<RadioOption> options { get; set; }
        }

        public class RadioOption
        {
            public string title { get; set; }
            public string name { get; set; }
            public int key { get; set; }
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

        public void AddControlsToGroupBox(GroupBox box, Control.ControlCollection controls)
        {
            // top margin = 3, height = 17, between margin = 6
            int currentHeight = 3;
            for (int i = 0; i < controls.Count; i++)
            {
                var ctrl = controls[i];
                ctrl.Location = new Point(6, currentHeight);
                box.Controls.Add(ctrl);
                currentHeight += ctrl.Size.Height;
            }
        }
    }
}

