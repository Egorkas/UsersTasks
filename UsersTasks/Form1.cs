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
        private const string UserChangedMessage = "Пользователь изменён!";
        private const string UserTaskChangedMessage = "Задача изменена!";
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

            GetUsers();
            GetTasks();
        }

        private void GetUsers()
        {
            var users = _userService.GetAll();
            usersDgv.DataSource = users;
        }

        private void GetTasks()
        {
            var tasks = _userTaskService.GetAll();
            userTasksDgv.DataSource = tasks;
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

                if (!string.IsNullOrWhiteSpace(username) 
                    && !string.IsNullOrWhiteSpace(age) 
                    && !string.IsNullOrWhiteSpace(email) 
                    && !string.IsNullOrWhiteSpace(rule))
                {
                    var user = new UserDTO { Name = username, Age = Int32.Parse(age), Email = email, Rule = rule };

                    _userService.Create(user);
                    MessageBox.Show(NewUserAddedMessage);
                    GetUsers();
                }
                else
                {
                    MessageBox.Show(EmptyTextboxMessage);
                    return;
                }
            }
        }

        private void changeUser_btn_Click(object sender, EventArgs e)
        {

            if (usersDgv.SelectedRows.Count > 0)
            {
                var lastCursor = GetLastCursorIndex(usersDgv);
                var selectedRows = GetUserSelectedRowsIds();

                var ChangeUserData_Form = new UserData();
                var user = _userService.FindById(GetUserSelectedRowsIds().First());
                ChangeUserData_Form.inputUserNameTextBox.Text = user.Name;
                ChangeUserData_Form.inputUserAgeTextBox.Text = user.Age.ToString();
                ChangeUserData_Form.inputUserEmailTextBox.Text = user.Email;
                ChangeUserData_Form.ruleOfUserComboBox.SelectedItem = user.Rule;

                if (ChangeUserData_Form.ShowDialog(this) == DialogResult.Cancel)
                    return;

                var username = ChangeUserData_Form.inputUserNameTextBox.Text;
                var age = ChangeUserData_Form.inputUserAgeTextBox.Text;
                var email = ChangeUserData_Form.inputUserEmailTextBox.Text;
                var rule = ChangeUserData_Form.ruleOfUserComboBox.SelectedItem.ToString();

                if (!string.IsNullOrWhiteSpace(username)
                    && !string.IsNullOrWhiteSpace(age)
                    && !string.IsNullOrWhiteSpace(email)
                    && !string.IsNullOrWhiteSpace(rule))
                {
                    var newUser = new UserDTO 
                    { Name = username
                    , Age = Int32.Parse(age)
                    , Email = email
                    , Rule = rule
                    , Id = GetUserSelectedRowsIds().First() 
                    };
                    _userService.Update(newUser);
                    MessageBox.Show(UserChangedMessage);
                    _userService.Remove(selectedRows.First());
                    GetUsers();
                }
                else
                {
                    MessageBox.Show(EmptyTextboxMessage);
                    return;
                }
            }



        }
        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            if (usersDgv.SelectedRows.Count > 0)
            {
                var lastCursor = GetLastCursorIndex(usersDgv);
                var selectedRows = GetUserSelectedRowsIds();

                foreach (var id in selectedRows)
                {
                    _userService.Remove(id);
                    usersDgv.DataSource = _userService.GetAll();
                }
                if (lastCursor > 0)
                {
                    usersDgv.CurrentCell = usersDgv.Rows[lastCursor - 1].Cells[0];
                }

                if (selectedRows.Count == 1)
                    MessageBox.Show(OneObjectDeletedMessage);
                else
                    MessageBox.Show(ManyObjectsDeletedMessage);
            }
        }

        private int GetLastCursorIndex(DataGridView dataGridView)
            => dataGridView
                .SelectedRows.OfType<DataGridViewRow>().ToArray().Last().Index;

        private List<int> GetUserSelectedRowsIds()
        {
            if (usersDgv.SelectedRows.Count > 0)
            {
                var selectedRows = usersDgv.SelectedRows.OfType<DataGridViewRow>().ToArray();
                var infoDatasource = (List<UserDTO>)usersDgv.DataSource;

                return selectedRows.Select(sr => infoDatasource[sr.Index].Id).ToList();
            }

            return null;
        }


        private void addTask_btn_Click(object sender, EventArgs e)
        {
            var AddNewTask_Form = new UserTasks();

            if (AddNewTask_Form.ShowDialog(this) == DialogResult.Cancel)
            
            {
                var taskName = AddNewTask_Form.inputNameOfTasktextBox.Text;
                var taskDescription = AddNewTask_Form.inputDescriptionOfTasktextBox.Text;
                var startTime = AddNewTask_Form.startDtp.Value;
                var endTime = AddNewTask_Form.deadLineDtp.Value;
                var status = AddNewTask_Form.statusTaskCmbBox.SelectedItem.ToString();

                if (!string.IsNullOrWhiteSpace(taskName)
                    && !string.IsNullOrWhiteSpace(taskDescription)
                    && !string.IsNullOrWhiteSpace(status))
                {
                    var taskUser = new UserTaskDTO
                    {
                        NameOfTask = taskName,
                        Description = taskDescription,
                        StartOfTask = startTime,
                        DeadLine = endTime,
                        Status = status,
                        UserId = GetUserSelectedRowsIds().First()
                    };

                    _userTaskService.Create(taskUser);
                    MessageBox.Show(TaskCompleteMessage);
                }
                GetTasks();
            }
            else if (AddNewTask_Form.ShowDialog(this) == DialogResult.OK)
                return;
        }
        private void changeTask_btn_Click(object sender, EventArgs e)
        {
            if (userTasksDgv.SelectedRows.Count > 0)
            {
                var lastCursor = GetLastCursorIndex(userTasksDgv);
                var selectedRows = GetTaskSelectedRowsIds();

                var ChangeUserTaskData_Form = new UserTasks();

                var userTask = _userTaskService.FindById(GetTaskSelectedRowsIds().First());
                ChangeUserTaskData_Form.inputNameOfTasktextBox.Text = userTask.NameOfTask;
                ChangeUserTaskData_Form.inputDescriptionOfTasktextBox.Text = userTask.Description;
                ChangeUserTaskData_Form.startDtp.Value = userTask.StartOfTask;
                ChangeUserTaskData_Form.deadLineDtp.Value = userTask.DeadLine;
                ChangeUserTaskData_Form.statusTaskCmbBox.SelectedItem = userTask.Status;

                if (ChangeUserTaskData_Form.ShowDialog(this) == DialogResult.OK)
                    return;

                var taskName = ChangeUserTaskData_Form.inputNameOfTasktextBox.Text;
                var taskDescription = ChangeUserTaskData_Form.inputDescriptionOfTasktextBox.Text;
                var startTime = ChangeUserTaskData_Form.startDtp.Value;
                var endTime = ChangeUserTaskData_Form.deadLineDtp.Value;
                var status = ChangeUserTaskData_Form.statusTaskCmbBox.SelectedItem.ToString();

                if (!string.IsNullOrWhiteSpace(taskName)
                    && !string.IsNullOrWhiteSpace(taskDescription))
                {
                    var newUserTask = new UserTaskDTO
                    {
                        NameOfTask = taskName
                    ,
                        Description = taskDescription
                    ,
                        StartOfTask = startTime
                    ,
                        DeadLine = endTime
                    ,
                        Status = status
                    ,
                        UserId = userTask.UserId
                    };
                    _userTaskService.Update(newUserTask);
                    MessageBox.Show(UserTaskChangedMessage);
                    _userTaskService.Remove(selectedRows.First());
                    GetTasks();
                }
                else
                {
                    MessageBox.Show(EmptyTextboxMessage);
                    return;
                }
            }
        }

        private void deleteTask_btn_Click(object sender, EventArgs e)
        {

            if (userTasksDgv.SelectedRows.Count > 0)
            {
                var lastCursor = GetLastCursorIndex(userTasksDgv);
                var selectedRows = GetTaskSelectedRowsIds();

                foreach (var id in selectedRows)
                    _userTaskService.Remove(id);

                userTasksDgv.DataSource = _userTaskService.GetAll();
                if (lastCursor > 0)
                {
                    userTasksDgv.CurrentCell = userTasksDgv.Rows[lastCursor - 1].Cells[0];
                }
            }               
        }

        private List<int> GetTaskSelectedRowsIds()
        {
            if (userTasksDgv.SelectedRows.Count > 0)
            {
                var selectedRows = userTasksDgv.SelectedRows.OfType<DataGridViewRow>().ToArray();
                var infoDatasource = (List<UserTaskDTO>)userTasksDgv.DataSource;

                return selectedRows.Select(row => infoDatasource[row.Index].Id).ToList();
            }

            return null;
        }

        private void usersDgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var userTasks = _userTaskService.GetAll().Where(src => src.UserId == GetUserSelectedRowsIds().First()).ToList();
            userTasksDgv.DataSource = userTasks;
        }
    }
}
