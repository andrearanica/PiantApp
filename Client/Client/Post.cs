using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Client {
    public partial class Post : Component {
        public Post() {
            InitializeComponent();
        }

        public Post(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }
    }
}
