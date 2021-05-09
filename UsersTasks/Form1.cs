using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskSheduler.BusinessLayer.DTO;
using TaskSheduler.BusinessLayer.Interfaces;

namespace UsersTasks
{

    public partial class Form1 : Form
    {
        private readonly IGenericServices<UserDTO> _userService;
        public Form1(IGenericServices<UserDTO> userService)
        {
            InitializeComponent();
            _userService = userService;

            usersDgv.DataSource = _userService.GetAll();
            
        }   
    }
}
