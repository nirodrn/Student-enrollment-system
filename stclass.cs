using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SESys
{
    public partial class stclass : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public stclass()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadRegistrationNumbers();
            LoadCourses();
        }
        private void InitializeDatabase()
        {
            string connectionString = "Data Source=DARK-N0\\SQLEXPRESS;Initial Catalog=EnrollmentSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            adapter = new SqlDataAdapter();
        }


        #region 1
        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void btnsave_Click(object sender, EventArgs e)
        {
            string regNo = comboBoxregno.Text;

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM StudentClasses WHERE RegNo = @RegNo";
                command.Parameters.AddWithValue("@RegNo", regNo);
                command.ExecuteNonQuery();

                foreach (var item in listBoxstudentcources.Items)
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO StudentClasses (RegNo, CourseName) VALUES (@RegNo, @CourseName)";
                    command.Parameters.AddWithValue("@RegNo", regNo);
                    command.Parameters.AddWithValue("@CourseName", item.ToString());
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Student classes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBoxregno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxregno.SelectedItem == null)
            {
                return;
            }
            string regNo = comboBoxregno.Text;
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT FullName, ContactNo FROM Student WHERE RegNo = @RegNo";
                command.Parameters.AddWithValue("@RegNo", regNo);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lblstudentinfo.Text = "Student Name: " + reader["FullName"] + "\nContact No: " + reader["ContactNo"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //do nothing
            }
            finally
            {
                connection.Close();
            }
            LoadStudentClasses(regNo);
            LoadStudentInformation(regNo);
        }

        private void comboBoxcoursdetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseName = comboBoxcoursdetails.Text;

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "SELECT CourseTimings FROM Courses WHERE CourseName = @CourseName";
                command.Parameters.AddWithValue("@CourseName", courseName);
                string courseTimings = command.ExecuteScalar()?.ToString();
                if (!string.IsNullOrEmpty(courseTimings))
                {
                    listBoxCoursetime.Items.Clear();
                    listBoxCoursetime.Items.AddRange(courseTimings.Split(','));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course timings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }




        private void btnassign_Click(object sender, EventArgs e)
        {
            if (listBoxCoursetime.SelectedItem != null)
            {
                listBoxstudentcources.Items.Add(listBoxCoursetime.SelectedItem);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (comboBoxregno.SelectedItem == null)
            {
                MessageBox.Show("Please select a registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string regNo = comboBoxregno.SelectedItem.ToString();

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM StudentClasses WHERE RegNo = @RegNo";
                command.Parameters.Clear(); // Clear existing parameters
                command.Parameters.AddWithValue("@RegNo", regNo); // Add the RegNo parameter
                command.ExecuteNonQuery();

                MessageBox.Show("Student classes for registration number " + regNo + " deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            listBoxstudentcources.Items.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (comboBoxregno.SelectedItem == null)
            {
                MessageBox.Show("Please select a registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string regNo = comboBoxregno.SelectedItem.ToString();

            try
            {
                connection.Open();

                command.CommandText = "DELETE FROM StudentClasses WHERE RegNo = @RegNo";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@RegNo", regNo);
                command.ExecuteNonQuery();

                foreach (var item in listBoxstudentcources.Items)
                {
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO StudentClasses (RegNo, CourseName) VALUES (@RegNo, @CourseName)";
                    command.Parameters.AddWithValue("@RegNo", regNo);
                    command.Parameters.AddWithValue("@CourseName", item.ToString());
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) // Check if it's a primary key violation error
                        {
                            continue;
                        }
                        else
                        {
                            // For other SQL errors, display the error message
                            throw;
                        }
                    }
                }
                MessageBox.Show("Student classes updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            comboBoxregno.SelectedIndex = -1;

            listBoxstudentcources.Items.Clear();
            lblstudentinfo.Text = "";
            listBoxCoursetime.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxstudentcources.SelectedItem != null)
            {

                listBoxstudentcources.Items.Remove(listBoxstudentcources.SelectedItem);
            }
            else
            {

                MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudentClasses(string regNo)
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT CourseName FROM StudentClasses WHERE RegNo = @RegNo";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@RegNo", regNo);
                SqlDataReader reader = command.ExecuteReader();


                listBoxstudentcources.Items.Clear();


                while (reader.Read())
                {
                    listBoxstudentcources.Items.Add(reader["CourseName"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadRegistrationNumbers()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT RegNo, CONCAT(FirstName, ' ', LastName) AS FullName, ContactNo FROM Student";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxregno.Items.Add(reader["RegNo"]);
                    comboBoxregno.DisplayMember = "FullName";
                    comboBoxregno.ValueMember = "RegNo";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registration numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadCourses()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT CourseName FROM Courses";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxcoursdetails.Items.Add(reader["CourseName"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void LoadStudentInformation(string regNo)
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT FirstName, LastName, ContactNo FROM Student WHERE RegNo = @RegNo";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@RegNo", regNo);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    lblstudentinfo.Text = "Student Name: " + fullName + " - Contact No: " + reader["ContactNo"].ToString();
                }
                else
                {

                    lblstudentinfo.Text = "";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
