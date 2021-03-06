﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace JSM.Web.Models.Shared.Resume {
    [XmlType]
    public class Paragraph : TextElement {
        [XmlText(typeof(string))]
        [XmlElement("Text", typeof(TextRun))]
        [XmlElement(typeof(Link))]
        public List<object> Content { get; set; }
    }
}
