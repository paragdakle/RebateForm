using Asg2_pxd160530.Entitiy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg2_pxd160530
{
    /// <remarks>
    /// Author: Parag Pravin Dakle
    /// Course: Human Computer Interaction CS 6326 Spring 2017
    /// Net ID: pxd160530
    /// </remarks>
    /// <summary>
    /// <c>partial class MainForm</c>
    /// This class consists of methods and event handlers interacting with the UI and consuming other lower layer classes.
    /// </summary>
    public partial class MainForm : Form
    {
        Validation validator;
        Buyer buyer;
        Buyer buyerBackupCopy;
        Dictionary<string, Buyer> buyerDictionary;
        ListViewComparer comparer;
        private const int ADD_OPERATION = 0;
        private const int MODIFY_DELETE_OPERATION = 1;
        private int currentOperation = ADD_OPERATION;
        private readonly string timeFormat = "HH:mm:ss";
        private readonly string errorMessagePrefix = "Invalid Field: ";
        private bool isCalendarDropDownVisible = false;

        /// <summary>
        /// Default constructor of the main class.
        /// Create the <c>Buyer</c> object, a dictionary to store buyers, <c>Validation</c> object and <c>ListViewComparer</c> object.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            buyer = new Buyer();
            buyerDictionary = new Dictionary<string, Buyer>();
            validator = new Validation();
            comparer = new ListViewComparer();
        }

        /// <summary>
        /// Method initializes the form by resetting all the controls. 
        /// Creates a new <c>Buyer</c> object.
        /// Disables all buttons.
        /// Gives the focus to the first control.
        /// </summary>
        private void initializeForm()
        {
            buyer = new Buyer();
            ctlFirstName.Text = "";
            ctlMiddleInitial.Text = "";
            ctlLastName.Text = "";
            ctlAddressLine1.Text = "";
            ctlAddressLine2.Text = "";
            ctlCity.Text = "";
            ctlState.Text = "";
            ctlZipCode.Text = "";
            ctlPhoneNumber.Text = "";
            ctlEmailAddress.Text = "";
            ctlProofOfPurchasedAttached.Checked = true;
            ctlProofOfPurchasedNotAttached.Checked = false;
            ctlDateReceived.Value = DateTime.Now;
            currentOperation = ADD_OPERATION;
            ctlModify.Enabled = false;
            ctlDelete.Enabled = false;
            ctlAdd.Enabled = false;
            ctlFirstName.Focus();
        }

        /// <summary>
        /// TextChange event handler method.
        /// Records the form filling start time;
        /// Resets the BackColor of TextBox Control to White,
        /// Displays the current operation being performed in the status bar;
        /// Validates the fields to enable the add button.
        /// </summary>
        /// <param name="sender">The object whose TextChange event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void ctl_TextChange(object sender, EventArgs e)
        {
            //If the form filling start time has not been set yet, set it.
            if (buyer.creationStartTime.Length == 0)
            {
                setFormFillingStartTime();
            }
            try
            {
                //If the invoking object is a Textbox, there is a chance that it showed an error before and the backcolor was turned red.
                //Reset the color to white.
                ((TextBox)sender).BackColor = Color.White;
            }
            catch(InvalidCastException ex)
            {
                //Handling the case when the invoking object is not a Textbox.
                Console.Out.Write(ex.StackTrace);
            }
            //Show current operation in the status bar.
            if(currentOperation == ADD_OPERATION)
            {
                showMessage("Adding details of a new buyer.");
            }
            else if(currentOperation == MODIFY_DELETE_OPERATION)
            {
                showMessage("Modifying details of a buyer.");
            }
            //Check if all the fields have been filled and if user is adding a new buyer then enable Add button.
            if (validator.validateMandatoryFields(this, false) && currentOperation == ADD_OPERATION)
            {
                ctlAdd.Enabled = true;
            }
        }

        /// <summary>
        /// Method validates all the fields for content presence and then individual fields.
        /// It prints the appropriate error, if any, on the status bar and also changes the BackColor of TextBox Control if needed.
        /// Uses the <c>Validation</c> class object.
        /// <see cref="Validation"/>
        /// </summary>
        /// <returns>True if all validations are successful else False</returns>
        private bool validate()
        {
            if (!validator.validateMandatoryFields(this, true))
            {
                showError("Please provide all mandatory fields!");
                return false;
            }
            if(!validator.validateName(ctlFirstName.Text))
            {
                ctlFirstName.BackColor = Color.Red;
                showError(errorMessagePrefix + "First Name");
                return false;
            }
            //Since middle initial is not a mandatory field, first check if it is present and then validate.
            if (!String.IsNullOrWhiteSpace(ctlMiddleInitial.Text) && !validator.validateMiddleInitial(ctlMiddleInitial.Text))
            {
                ctlMiddleInitial.BackColor = Color.Red;
                showError(errorMessagePrefix + "Middle Initial");
                return false;
            }
            else
            {
                buyer.middleInitial = ctlMiddleInitial.Text;
            }
            buyer.firstName = ctlFirstName.Text;
            if (!validator.validateName(ctlLastName.Text))
            {
                ctlLastName.BackColor = Color.Red;
                showError(errorMessagePrefix + "Last Name");
                return false;
            }
            buyer.lastName = ctlLastName.Text;
            buyer.addressLine1 = ctlAddressLine1.Text;
            buyer.addressLine2 = ctlAddressLine2.Text;
            if (!validator.validateCity(ctlCity.Text))
            {
                ctlCity.BackColor = Color.Red;
                showError(errorMessagePrefix + "City");
                return false;
            }
            buyer.city = ctlCity.Text;
            if (!validator.validateState(ctlState.Text))
            {
                ctlState.BackColor = Color.Red;
                showError(errorMessagePrefix + "State. Accepted state formats: AA, aa, Aa, aA");
                return false;
            }
            buyer.state = ctlState.Text;
            if (!validator.validateZipCode(ctlZipCode.Text))
            {
                ctlState.BackColor = Color.Red;
                showError(errorMessagePrefix + "Zip code. Accepted zip code formats: XXXXX or XXXXX-XXXX");
                return false;
            }
            buyer.zipCode = ctlZipCode.Text;
            buyer.phoneNumber = ctlPhoneNumber.Text;
            if (!validator.validateEmailAddress(ctlEmailAddress.Text))
            {
                ctlEmailAddress.BackColor = Color.Red;
                showError(errorMessagePrefix + "Email Address");
                return false;
            }
            buyer.email = ctlEmailAddress.Text;
            buyer.proofOfPurchase = ctlProofOfPurchasedAttached.Checked;
            buyer.dateReceived = ctlDateReceived.Value.ToString();
            return true;
        }

        /// <summary>
        /// Method records the time when the form filling started.
        /// </summary>
        private void setFormFillingStartTime()
        {
            buyer.creationStartTime = DateTime.Now.ToString(timeFormat);
        }

        /// <summary>
        /// Method displays the given message in the status bar. 
        /// It also resets the text color to Black indicating a normal message is being displayed.
        /// </summary>
        /// <param name="message">Message to display</param>
        private void showMessage(String message)
        {
            lblActivityStatusBar.Text = message;
            lblActivityStatusBar.ForeColor = Color.Black;
        }

        /// <summary>
        /// Method displays the given error in the status bar. 
        /// It also sets the text color to Red indicating an error message is being displayed.
        /// </summary>
        /// <param name="error">Message to display</param>
        private void showError(String error)
        {
            lblActivityStatusBar.Text = error;
            lblActivityStatusBar.ForeColor = Color.Red;
        }

        /// <summary>
        /// Add button click event handler method.
        /// First calls <c>validate</c> method to check if the data is valid. <see cref="MainForm.validate"/>
        /// Then adds the buyer object to the dictionary and calls <c>saveRecords</c> method to save all the records <see cref="MainForm.saveRecords"/> to storage media.
        /// Then populates the list view <see cref="MainForm.populateListView"/> and resets the form <see cref="MainForm.initializeForm"/>.
        /// </summary>
        /// <param name="sender">The object whose click event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void ctlAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string[] row = { buyer.getFullName(), buyer.phoneNumber };
                try
                {
                    //Record the form filling finish time
                    buyer.creationEndTime = DateTime.Now.ToString(timeFormat);
                    buyerDictionary.Add(row[0], buyer);
                    showMessage("Saving buyers");
                    saveRecords();
                    showMessage("Done. Buyers saved.");
                    populateListView();
                    initializeForm();
                    ctlAdd.Enabled = false;
                }
                catch (ArgumentException ex)
                {
                    Console.Out.Write(ex.StackTrace);
                    showError("Buyer with same full name already present!");
                    return;
                }
            }
        }

        /// <summary>
        /// Form load event handler method.
        /// Initializes the form controls <see cref="MainForm.initializeForm"/>;
        /// Loads the records in a dictionary <see cref="MainForm.loadRecords"/>;
        /// Populates the list view with loaded data <see cref="MainForm.populateListView"/>.
        /// </summary>
        /// <param name="sender">The object whose on load event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            initializeForm();
            showMessage("Loading buyers...");
            loadRecords();
            showMessage("Done. " + buyerDictionary.Count + " buyer(s) found!");
            populateListView();
            //Disable resizing of the form
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            //Change the default ListViewItemSorter with comparer.
            ctlRecordListView.ListViewItemSorter = comparer;
        }

        /// <summary>
        /// Method saves the records present in the buyer dictionary on the storage media.
        /// <see cref="RecordManager{S, T}"/>
        /// <seealso cref="RecordManager{S, T}.writeRecords(Dictionary{S, T})"/>
        /// </summary>
        private void saveRecords()
        {
            RecordManager<string, Buyer> manager = new RecordManager<string, Buyer>();
            manager.writeRecords(buyerDictionary);
        }

        /// <summary>
        /// Method loads buyer records from the storage media, if present, in the buyer dictionary.
        /// <see cref="RecordManager{S, T}"/>
        /// <seealso cref="RecordManager{S, T}.readAllRecords"/>
        /// </summary>
        private void loadRecords()
        {
            RecordManager<string, Buyer> manager = new RecordManager<string, Buyer>();
            List<string> records = manager.readAllRecords();
            buyerDictionary.Clear();
            foreach(string record in records)
            {
                Buyer entity = new Buyer();
                entity.populateBuyer(record);
                buyerDictionary.Add(entity.getFullName(), entity);
            }
        }

        /// <summary>
        /// Method populates the list view with buy records present in the dictionary.
        /// </summary>
        private void populateListView()
        {
            ctlRecordListView.Items.Clear();
            List<Buyer> buyerList = buyerDictionary.Values.ToList();
            foreach(Buyer buyer in buyerList)
            {
                string[] row = { buyer.getFullName(), buyer.phoneNumber };
                var listViewItem = new ListViewItem(row);
                try
                {
                    ctlRecordListView.Items.Add(listViewItem);
                }
                catch(Exception e)
                {
                    Console.Out.Write(e.StackTrace);
                }
            }
            if (ctlRecordListView.Items.Count > 0)
            {
                //Ensure that the newly added record at the end is always visible.
                ctlRecordListView.EnsureVisible(ctlRecordListView.Items.Count - 1);
            }
        }

        /// <summary>
        /// ListView selected item index change event handler method.
        /// Loads the details of the buyer, if any selected, in the form for update operation.
        /// If a buyer is deselected the form is cleared.
        /// </summary>
        /// <param name="sender">The object whose selected index change event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void ctlRecordListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMessage("Populating buyer details...");
            initializeForm();
            ListView.SelectedListViewItemCollection records = this.ctlRecordListView.SelectedItems;
            foreach (ListViewItem item in records)
            {
                if(buyerDictionary.ContainsKey(item.SubItems[0].Text))
                {
                    buyerDictionary.TryGetValue(item.SubItems[0].Text, out buyer);
                    buyerBackupCopy = new Buyer(buyer);
                    ctlFirstName.Text = buyer.firstName;
                    ctlMiddleInitial.Text = buyer.middleInitial;
                    ctlLastName.Text = buyer.lastName;
                    ctlAddressLine1.Text = buyer.addressLine1;
                    ctlAddressLine2.Text = buyer.addressLine2;
                    ctlCity.Text = buyer.city;
                    ctlState.Text = buyer.state;
                    ctlZipCode.Text = buyer.zipCode;
                    ctlPhoneNumber.Text = buyer.phoneNumber;
                    ctlEmailAddress.Text = buyer.email;
                    ctlProofOfPurchasedAttached.Checked = buyer.proofOfPurchase;
                    ctlProofOfPurchasedNotAttached.Checked = !buyer.proofOfPurchase;
                    ctlDateReceived.Value = Convert.ToDateTime(buyer.dateReceived);
                    showMessage("Loaded record for updating.");
                }
            }
            //If some buyer record was selected
            if(records.Count > 0) {
                currentOperation = MODIFY_DELETE_OPERATION;
                ctlModify.Enabled = true;
                ctlDelete.Enabled = true;
                ctlAdd.Enabled = false;
                showMessage("Done. Buyer details populated.");
            }
            else
            {
                initializeForm();
            }
        }

        /// <summary>
        /// Delete button click event handler method.
        /// First check if an object was loaded from the list view for an update operation
        /// Then removes the buyer object from the dictionary and calls <c>saveRecords</c> method to save all the records <see cref="MainForm.saveRecords"/> to storage media.
        /// Then populates the list view <see cref="MainForm.populateListView"/> and resets the form <see cref="MainForm.initializeForm"/>.
        /// </summary>
        /// <param name="sender">The object whose click event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void ctlDelete_Click(object sender, EventArgs e)
        {
            if (buyerBackupCopy != null && buyerDictionary.ContainsKey(buyerBackupCopy.getFullName()))
            {
                buyerDictionary.Remove(buyerBackupCopy.getFullName());
                showMessage("Deleting Buyer...");
                saveRecords();
                showMessage("Done. Buyer deleted.");
                populateListView();
                initializeForm();
            }
        }

        /// <summary>
        /// Modify button click event handler method.
        /// First validate the record modifications. <see cref="MainForm.validate"/>
        /// Then check if the full name of the buyer was changed. If no, update the old record else check if there exists a record with the same full name in the dictionary and insert if not found.
        /// Finally, call <c>saveRecords</c> method to save all the records <see cref="MainForm.saveRecords"/> to storage media.
        /// Then populates the list view <see cref="MainForm.populateListView"/> and resets the form <see cref="MainForm.initializeForm"/>.
        /// </summary>
        /// <param name="sender">The object whose click event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void ctlModify_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (buyerBackupCopy.getFullName().Equals(buyer.getFullName()))
                {
                    buyerDictionary[buyer.getFullName()] = buyer;
                    showMessage("Updating records...");
                    saveRecords();
                    showMessage("Done. Records updated.");
                    populateListView();
                    initializeForm();
                }
                else if (!buyerDictionary.ContainsKey(buyer.getFullName()))
                {
                    buyerDictionary.Add(buyer.getFullName(), buyer);
                    buyerDictionary.Remove(buyerBackupCopy.getFullName());
                    buyer = buyerBackupCopy = null;
                    showMessage("Updating records...");
                    saveRecords();
                    showMessage("Done. Records updated.");
                    populateListView();
                    initializeForm();
                }
                else
                {
                    showError("Buyer with same first name already present!");
                }
            }
        }

        /// <summary>
        /// ListView column click event handler method.
        /// Sorts the list view items based on the column clicked.
        /// </summary>
        /// <param name="sender">The list view object whose column click event is being handled</param>
        /// <param name="e">EventArgs object.</param>
        private void ctlRecordListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != comparer.SortColumn)
            {
                comparer.SortColumn = e.Column;
                comparer.Order = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (comparer.Order == SortOrder.Ascending) {
                    comparer.Order = SortOrder.Descending;
                }
                else {
                    comparer.Order = SortOrder.Ascending;
                }
            }
            ctlRecordListView.Sort();
        }

        /// <summary>
        /// Form key press event handler.
        /// Checks if the esc key was pressed and if the calendar drop down is not being shown then clears the form.
        /// </summary>
        /// <param name="sender">The Form object whose keypress event is being handled</param>
        /// <param name="e">KeyPressEventArgs object</param>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                if(!isCalendarDropDownVisible)
                    initializeForm();
            }
        }

        /// <summary>
        /// DateTime picker dropdrop open event handler.
        /// Sets a flag to record that the dropdown is being displayed.
        /// </summary>
        /// <param name="sender">The DateTime object whose dropdown open event is being handled.</param>
        /// <param name="e">EventArgs object</param>
        private void ctlDateReceived_DropDown(object sender, EventArgs e)
        {
            isCalendarDropDownVisible = true;
        }

        /// <summary>
        /// DateTime picker dropdrop close event handler.
        /// Sets a flag to record that the dropdown has closed.
        /// </summary>
        /// <param name="sender">The DateTime object whose dropdown close event is being handled.</param>
        /// <param name="e">EventArgs object</param>
        private void ctlDateReceived_CloseUp(object sender, EventArgs e)
        {
            isCalendarDropDownVisible = false;
        }
    }
}