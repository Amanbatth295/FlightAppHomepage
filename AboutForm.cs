using System;

public class Class1
{
	public Class1()
	{
        private void AboutUsForm_Load(object sender, EventArgs e)
        {
            // Read the content from the text file
            string aboutUsContent = File.ReadAllText("about_us.txt");

            // Set the content in the rich text box control
            rtbAboutUs.Text = aboutUsContent;
        }
    }
}
