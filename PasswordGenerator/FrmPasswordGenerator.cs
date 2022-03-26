using System;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator
{
	public partial class frmPasswordGenerator : Form
	{
		public frmPasswordGenerator()
		{
			InitializeComponent();
		}

		// All special characters
		private void rbAllSpec_Click(object sender, EventArgs e)
		{
			chkIsTroll.Checked = true;
			foreach (CheckBox sc in grpCommonSpecChars.Controls.OfType<CheckBox>())
			{
				sc.Checked = true;
			}
			foreach (CheckBox sc in grpAddlSpecChars.Controls.OfType<CheckBox>())
			{
				sc.Checked = true;
			}
		}

		// Custom selection
		private void rbCustomSpecChars_Click(object sender, EventArgs e)
		{
			foreach (CheckBox sc in grpCommonSpecChars.Controls.OfType<CheckBox>())
			{
				sc.Checked = false;
			}
			foreach (CheckBox sc in grpAddlSpecChars.Controls.OfType<CheckBox>())
			{
				sc.Checked = false;
			}
			chkIsTroll.Checked = false;
		}

		// Common special characters only
		private void rbCommonSpecChars_Click(object sender, EventArgs e)
		{
			chkIsTroll.Checked = false;
			foreach (CheckBox sc in grpCommonSpecChars.Controls.OfType<CheckBox>())
			{
				sc.Checked = true;
			}
			foreach (CheckBox sc in grpAddlSpecChars.Controls.OfType<CheckBox>())
			{
				sc.Checked = false;
			}
		}

		// No special characters
		private void rbNoneSpec_Click(object sender, EventArgs e)
		{
			chkIsTroll.Checked = false;
			foreach (CheckBox sc in grpCommonSpecChars.Controls.OfType<CheckBox>())
			{
				sc.Checked = false;
			}
			foreach (CheckBox sc in grpAddlSpecChars.Controls.OfType<CheckBox>())
			{
				sc.Checked = false;
			}
		}

		// Individual special characters
		private void chkSC_Click(object sender, EventArgs e)
		{
			bool isCustom = false;
			bool initCommonSpecCharValue = chk33.Checked;
			bool initAddlSpecCharValue = chk34.Checked;

			foreach (CheckBox sc in grpCommonSpecChars.Controls.OfType<CheckBox>())
			{
				if (sc.Checked != initCommonSpecCharValue)
				{
					isCustom = true;
					break;
				}
			}

			if (!isCustom)
			{
				// common are all checked or all unchecked
				foreach (CheckBox sc in grpAddlSpecChars.Controls.OfType<CheckBox>())
				{
					if (sc.Checked != initAddlSpecCharValue)
					{
						isCustom = true;
						break;
					}
				}
			}

			if (isCustom) { setRadioButtons(false, false, false); }
			else if (initCommonSpecCharValue && initAddlSpecCharValue) { setRadioButtons(true, false, false); }
			else if (initCommonSpecCharValue && !initAddlSpecCharValue) { setRadioButtons(false, true, false); }
			else { setRadioButtons(false, false, true); }
		}

		public void setRadioButtons(bool isAllChecked, bool isCommonChecked, bool isNoneChecked)
		{
			rbAllSpecChars.Checked = isAllChecked;
			rbCommonSpecChars.Checked = isCommonChecked;
			rbNoSpecChars.Checked = isNoneChecked;
			rbCustomSpecChars.Checked = !isAllChecked && !isCommonChecked && !isNoneChecked;
		}

		private void Common_SelectAll(object sender, EventArgs e)
		{
			if (sender is TextBox txtBox)
			{
				txtBox.SelectAll();

				if (txtBox.Name.Equals("txtPassword") && !string.IsNullOrEmpty(txtBox.Text))
				{
					Clipboard.SetText(txtBox.Text);
				}
			}
		}

		private void btnGeneratePassword_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			int alphaCount = 0;
			string commonSpecialChars = @"!@#$%^&*()";
			string addlSpecChars = @"~_-+=`|\{}[]:;""'<>,.?/";
			string password = string.Empty;

			if (ErrorCheck()) { return; }

			int minLen = Convert.ToInt32(txtMinLen.Text);
			int maxLen = Convert.ToInt32(txtMaxLen.Text);

			// Generate password base, make sure it contains at least two alphabetic characters
			do
			{
				password = string.Empty;

				do
				{
					password += Guid.NewGuid().ToString().Replace("-", string.Empty);
				}
				while (password.Length <= maxLen);

				// Reduce max by 1 if using special character
				int rngMax = rbNoSpecChars.Checked ? maxLen : maxLen - 1;
				int rLen = rand.Next(minLen, rngMax);
				password = password.Substring(0, rLen);
				alphaCount = 0;

				foreach (char c in password)
				{
					if (char.IsLetter(c))
					{
						alphaCount++;
						if (alphaCount == 2) { break; }
					}
				}
			}
			while (alphaCount < 2);

			// Uppercase first alphabetic character
			int charPos = 0;
			foreach (char c in password)
			{
				if (char.IsLetter(c))
				{
					string s = c.ToString().ToUpper();
					if (charPos == 0)
					{
						password = s + password.Substring(1);
					}
					else
					{
						password = password.Substring(0, charPos) + s + password.Substring(charPos + 1);
					}

					break;
				}

				charPos++;
			}

			string newPassword;
			// Remove unselected special characters
			if (rbNoSpecChars.Checked)
			{
				newPassword = password;
			}
			else
			{
				// Add troll comma
				if (chkIsTroll.Checked)
				{
					Random die = new Random();
					int commaInsertPos = die.Next(1, password.Length - 2);
					password = $"{password.Substring(0, commaInsertPos)},{password.Substring(commaInsertPos)}";
				}

				string selectChars = string.Empty;
				if (rbAllSpecChars.Checked)
				{
					selectChars = commonSpecialChars + addlSpecChars;
				}
				else if (rbCommonSpecChars.Checked)
				{
					selectChars = commonSpecialChars;
				}
				else
				{
					foreach (CheckBox sc in grpCommonSpecChars.Controls.OfType<CheckBox>())
					{
						if (sc.Checked) { selectChars += Convert.ToChar(Convert.ToInt32(sc.Name.Substring(3))); }
					}
					foreach (CheckBox sc in grpAddlSpecChars.Controls.OfType<CheckBox>())
					{
						if (sc.Checked) { selectChars += Convert.ToChar(Convert.ToInt32(sc.Name.Substring(3))); }
					}
				}

				if (!string.IsNullOrEmpty(selectChars))
				{
					// Add special character and output password
					int specCharPos = rand.Next(0, selectChars.Length - 1);
					newPassword = password + selectChars.Substring(specCharPos, 1);
				}
				else
				{
					newPassword = password;
				}

			}

			txtPassword.Text = newPassword;
			txtPassword.SelectAll();
			Clipboard.SetText(txtPassword.Text);
		}

		private bool ErrorCheck()
		{
			bool isError = false;
			string errorMsg = string.Empty;

			if (int.TryParse(txtMinLen.Text, out int minLen) && int.TryParse(txtMaxLen.Text, out int maxLen))
			{
				if (minLen < 6)
				{
					errorMsg = "Min length cannot be less than 6";
					isError = true;
				}

				if (minLen > 50)
				{
					errorMsg = "Min length cannot be greater than 50";
					isError = true;
				}

				if (maxLen < 6)
				{
					errorMsg += isError ? "\n" : "";
					errorMsg += "Max length cannot be less than 6";
					isError = true;
				}

				if (maxLen > 50)
				{
					errorMsg += isError ? "\n" : "";
					errorMsg += "Max length cannot be greater than 50";
					isError = true;
				}

				if (minLen > maxLen)
				{
					errorMsg += isError ? "\n" : "";
					errorMsg += "Min length cannot be greater than max length";
					isError = true;
				}
			}
			else
			{
				errorMsg = "Min and max values must be a numeric value between 6-50";
				isError = true;
			}

			if (isError)
			{
				MessageBox.Show(errorMsg, "Error");
			}

			return isError;
		}

		private void chk44_CheckedChanged(object sender, EventArgs e)
		{
			if (!chk44.Checked)
			{
				chkIsTroll.Checked = false;
			}
		}
	}
}