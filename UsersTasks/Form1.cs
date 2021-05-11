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
        private const string TaskCompleteMessage = "Задача успешно добавлена!";
        private const string NewUserAddedMessage = "Новый пользователь добавлен!";
        private const string ErrorWhileAddedUserMessage = "Произошла ошибка при добавлении пользователя!";
        private const string EmptyTextboxMessage = "Поле ввода имени пользователя не должно быть пустым!";
        private const string OneObjectDeletedMessage = "Объект удален!";
        private const string ManyObjectsDeletedMessage = "Объекты удалены!";
        private const string OneObjectUpdateMessage = "Объект изменен!";
        private const string ManyObjectsUpdatedMessage = "Объекты изменены!";


        private readonly IGenericServices<UserDTO> _userService;
        private readonly IGenericServices<UserTaskDTO> _userTaskService;
        public Form1(IGenericServices<UserDTO> userService, IGenericServices<UserTaskDTO> userTaskService)
        {
            InitializeComponent();
            _userService = userService;
            _userTaskService = userTaskService;

            usersDgv.DataSource = _userService.GetAll();            
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            var AddNewUser_Form = new UserData();

            if (AddNewUser_Form.ShowDialog(this) == DialogResult.Cancel)
                return;
            else
            {
                var username = AddNewUser_Form.inputUserNameTextBox.Text;
                var age = AddNewUser_Form.inputUserAgeTextBox.Text;
                var email = AddNewUser_Form.inputUserEmailTextBox.Text;
                var rule = AddNewUser_Form.ruleOfUserComboBox.SelectedItem.ToString();

                if (!string.IsNullOrWhiteSpace(username))
                {
                    var user = new UserDTO { Name = username, Age = Int32.Parse(age), Email = email, Rule = rule };

                    _userService.Create(user);
                    MessageBox.Show(NewUserAddedMessage);
                }
                else
                {
                    MessageBox.Show(EmptyTextboxMessage);
                    return;
                }
            }
        }
    }
}
