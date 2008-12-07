﻿#region "License Agreement"
/* Skimpt, an open source screenshot utility.
      Copyright (C) <year>  <name of author>

      This program is free software: you can redistribute it and/or modify
      it under the terms of the GNU General Public License as published by
      the Free Software Foundation, either version 3 of the License, or
      (at your option) any later version.

      this program is distributed in the hope that it will be useful,
      but WITHOUT ANY WARRANTY; without even the implied warranty of
      MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      GNU General Public License for more details.

      You should have received a copy of the GNU General Public License
      along with this program.  If not, see <http://www.gnu.org/licenses/>. */
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using Util;
using Microsoft.Win32;
using Microsoft.CSharp;
using System.Threading;
using System.ComponentModel;
using System.Collections.Generic;



public class main : Form
{
    #region GUI CODE - DO NOT CHANGE
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.startHighlightModeBtn = new System.Windows.Forms.Button();
        this.updateMessageLabel = new System.Windows.Forms.Label();
        this.toggleCamButton = new System.Windows.Forms.Button();
        this.unhookButton = new System.Windows.Forms.Button();
        this.mainProgramMessage = new System.Windows.Forms.TextBox();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.randomnameoptions = new System.Windows.Forms.GroupBox();
        this.filenameasrandomoption = new System.Windows.Forms.RadioButton();
        this.filenameasdateoption = new System.Windows.Forms.RadioButton();
        this.saveFileSettingBtn = new System.Windows.Forms.Button();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.browseButton = new System.Windows.Forms.Button();
        this.fileLocationTextBox = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.radioButton2 = new System.Windows.Forms.RadioButton();
        this.radioButton1 = new System.Windows.Forms.RadioButton();
        this.tabPage3 = new System.Windows.Forms.TabPage();
        this.ftpDirTxtBox = new System.Windows.Forms.TextBox();
        this.ftpPortTxtBox = new System.Windows.Forms.TextBox();
        this.ftpPassTxtBox = new System.Windows.Forms.TextBox();
        this.ftpUserTxtBox = new System.Windows.Forms.TextBox();
        this.ftpSettingsBtn = new System.Windows.Forms.Button();
        this.ftptestConnectionbutton = new System.Windows.Forms.Button();
        this.ftpHostTxtBox = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.tabPage4 = new System.Windows.Forms.TabPage();
        this.saveGlobalSettingsBtn = new System.Windows.Forms.Button();
        this.KillCheckbox = new System.Windows.Forms.CheckBox();
        this.ShowMessagesCheckbox = new System.Windows.Forms.CheckBox();
        this.AllowPluginsCheckbox = new System.Windows.Forms.CheckBox();
        this.HideUponLaunchCheckbox = new System.Windows.Forms.CheckBox();
        this.startOnWindowsLoadCheckBox = new System.Windows.Forms.CheckBox();
        this.tabPage5 = new System.Windows.Forms.TabPage();
        this.fontDialog1 = new System.Windows.Forms.FontDialog();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.randomnameoptions.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.tabPage3.SuspendLayout();
        this.tabPage4.SuspendLayout();
        this.SuspendLayout();
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Controls.Add(this.tabPage4);
        this.tabControl1.Controls.Add(this.tabPage5);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tabControl1.HotTrack = true;
        this.tabControl1.ItemSize = new System.Drawing.Size(96, 26);
        this.tabControl1.Location = new System.Drawing.Point(0, 0);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.ShowToolTips = true;
        this.tabControl1.Size = new System.Drawing.Size(483, 250);
        this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
        this.tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.tabPage1.Controls.Add(this.startHighlightModeBtn);
        this.tabPage1.Controls.Add(this.updateMessageLabel);
        this.tabPage1.Controls.Add(this.toggleCamButton);
        this.tabPage1.Controls.Add(this.unhookButton);
        this.tabPage1.Controls.Add(this.mainProgramMessage);
        this.tabPage1.Location = new System.Drawing.Point(4, 30);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(475, 216);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Main";
        this.tabPage1.ToolTipText = "Main screen";
        // 
        // startHighlightModeBtn
        // 
        this.startHighlightModeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
        this.startHighlightModeBtn.Location = new System.Drawing.Point(228, 73);
        this.startHighlightModeBtn.Name = "startHighlightModeBtn";
        this.startHighlightModeBtn.Size = new System.Drawing.Size(214, 36);
        this.startHighlightModeBtn.TabIndex = 4;
        this.startHighlightModeBtn.Text = "Start Highlight Mode";
        this.startHighlightModeBtn.UseVisualStyleBackColor = false;
        this.startHighlightModeBtn.Click += new System.EventHandler(this.startHighlightModeBtn_Click);
        // 
        // updateMessageLabel
        // 
        this.updateMessageLabel.AutoSize = true;
        this.updateMessageLabel.ForeColor = System.Drawing.Color.Red;
        this.updateMessageLabel.Location = new System.Drawing.Point(8, 112);
        this.updateMessageLabel.Name = "updateMessageLabel";
        this.updateMessageLabel.Size = new System.Drawing.Size(392, 19);
        this.updateMessageLabel.TabIndex = 3;
        this.updateMessageLabel.Text = "New Update Available on http://code.google.com/p/skimpt";
        this.updateMessageLabel.Visible = false;
        // 
        // toggleCamButton
        // 
        this.toggleCamButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
        this.toggleCamButton.Location = new System.Drawing.Point(8, 73);
        this.toggleCamButton.Name = "toggleCamButton";
        this.toggleCamButton.Size = new System.Drawing.Size(214, 36);
        this.toggleCamButton.TabIndex = 2;
        this.toggleCamButton.Text = "Toggle Screen Camera";
        this.toggleCamButton.UseVisualStyleBackColor = false;
        this.toggleCamButton.Click += new System.EventHandler(this.toggleCamButton_Click);
        // 
        // unhookButton
        // 
        this.unhookButton.Location = new System.Drawing.Point(318, 175);
        this.unhookButton.Name = "unhookButton";
        this.unhookButton.Size = new System.Drawing.Size(149, 33);
        this.unhookButton.TabIndex = 1;
        this.unhookButton.Text = "Unhook Print Screen";
        this.unhookButton.UseVisualStyleBackColor = true;
        this.unhookButton.Click += new System.EventHandler(this.unhookButton_Click);
        // 
        // mainProgramMessage
        // 
        this.mainProgramMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.mainProgramMessage.ForeColor = System.Drawing.Color.Green;
        this.mainProgramMessage.Location = new System.Drawing.Point(8, 19);
        this.mainProgramMessage.Multiline = true;
        this.mainProgramMessage.Name = "mainProgramMessage";
        this.mainProgramMessage.Size = new System.Drawing.Size(463, 48);
        this.mainProgramMessage.TabIndex = 0;
        this.mainProgramMessage.Text = "Program messages will be displayed here";
        // 
        // tabPage2
        // 
        this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.tabPage2.Controls.Add(this.randomnameoptions);
        this.tabPage2.Controls.Add(this.saveFileSettingBtn);
        this.tabPage2.Controls.Add(this.groupBox1);
        this.tabPage2.Controls.Add(this.radioButton2);
        this.tabPage2.Controls.Add(this.radioButton1);
        this.tabPage2.Location = new System.Drawing.Point(4, 30);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(475, 216);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "File";
        this.tabPage2.ToolTipText = "change file settings including save path";
        // 
        // randomnameoptions
        // 
        this.randomnameoptions.Controls.Add(this.filenameasrandomoption);
        this.randomnameoptions.Controls.Add(this.filenameasdateoption);
        this.randomnameoptions.Location = new System.Drawing.Point(240, 3);
        this.randomnameoptions.Name = "randomnameoptions";
        this.randomnameoptions.Size = new System.Drawing.Size(227, 78);
        this.randomnameoptions.TabIndex = 5;
        this.randomnameoptions.TabStop = false;
        this.randomnameoptions.Text = "Random Filenames as";
        this.randomnameoptions.Visible = false;
        // 
        // filenameasrandomoption
        // 
        this.filenameasrandomoption.AutoSize = true;
        this.filenameasrandomoption.Location = new System.Drawing.Point(6, 52);
        this.filenameasrandomoption.Name = "filenameasrandomoption";
        this.filenameasrandomoption.Size = new System.Drawing.Size(129, 23);
        this.filenameasrandomoption.TabIndex = 1;
        this.filenameasrandomoption.TabStop = true;
        this.filenameasrandomoption.Text = "Random Letters";
        this.filenameasrandomoption.UseVisualStyleBackColor = true;
        // 
        // filenameasdateoption
        // 
        this.filenameasdateoption.AutoSize = true;
        this.filenameasdateoption.Location = new System.Drawing.Point(6, 23);
        this.filenameasdateoption.Name = "filenameasdateoption";
        this.filenameasdateoption.Size = new System.Drawing.Size(174, 23);
        this.filenameasdateoption.TabIndex = 0;
        this.filenameasdateoption.TabStop = true;
        this.filenameasdateoption.Text = "Current Date and Time";
        this.filenameasdateoption.UseVisualStyleBackColor = true;
        // 
        // saveFileSettingBtn
        // 
        this.saveFileSettingBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        this.saveFileSettingBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.saveFileSettingBtn.ForeColor = System.Drawing.Color.DarkGreen;
        this.saveFileSettingBtn.Location = new System.Drawing.Point(136, 179);
        this.saveFileSettingBtn.Name = "saveFileSettingBtn";
        this.saveFileSettingBtn.Size = new System.Drawing.Size(221, 31);
        this.saveFileSettingBtn.TabIndex = 4;
        this.saveFileSettingBtn.Text = "Save File Settings";
        this.saveFileSettingBtn.UseVisualStyleBackColor = false;
        this.saveFileSettingBtn.Click += new System.EventHandler(this.saveFileSettingBtn_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.browseButton);
        this.groupBox1.Controls.Add(this.fileLocationTextBox);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Location = new System.Drawing.Point(9, 84);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(463, 92);
        this.groupBox1.TabIndex = 3;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "File Location";
        // 
        // browseButton
        // 
        this.browseButton.Location = new System.Drawing.Point(416, 49);
        this.browseButton.Name = "browseButton";
        this.browseButton.Size = new System.Drawing.Size(32, 27);
        this.browseButton.TabIndex = 2;
        this.browseButton.Text = "...";
        this.browseButton.UseVisualStyleBackColor = true;
        this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
        // 
        // fileLocationTextBox
        // 
        this.fileLocationTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.fileLocationTextBox.Location = new System.Drawing.Point(17, 50);
        this.fileLocationTextBox.Name = "fileLocationTextBox";
        this.fileLocationTextBox.ReadOnly = true;
        this.fileLocationTextBox.Size = new System.Drawing.Size(393, 27);
        this.fileLocationTextBox.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(13, 27);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(191, 19);
        this.label1.TabIndex = 0;
        this.label1.Text = "Save my file to this location:";
        // 
        // radioButton2
        // 
        this.radioButton2.AutoSize = true;
        this.radioButton2.Location = new System.Drawing.Point(26, 56);
        this.radioButton2.Name = "radioButton2";
        this.radioButton2.Size = new System.Drawing.Size(213, 23);
        this.radioButton2.TabIndex = 1;
        this.radioButton2.TabStop = true;
        this.radioButton2.Text = "Allow me to specify each file";
        this.radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton1
        // 
        this.radioButton1.AutoSize = true;
        this.radioButton1.Location = new System.Drawing.Point(26, 26);
        this.radioButton1.Name = "radioButton1";
        this.radioButton1.Size = new System.Drawing.Size(185, 23);
        this.radioButton1.TabIndex = 0;
        this.radioButton1.TabStop = true;
        this.radioButton1.Text = "Randomly name my files";
        this.radioButton1.UseVisualStyleBackColor = true;
        this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
        // 
        // tabPage3
        // 
        this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.tabPage3.Controls.Add(this.ftpDirTxtBox);
        this.tabPage3.Controls.Add(this.ftpPortTxtBox);
        this.tabPage3.Controls.Add(this.ftpPassTxtBox);
        this.tabPage3.Controls.Add(this.ftpUserTxtBox);
        this.tabPage3.Controls.Add(this.ftpSettingsBtn);
        this.tabPage3.Controls.Add(this.ftptestConnectionbutton);
        this.tabPage3.Controls.Add(this.ftpHostTxtBox);
        this.tabPage3.Controls.Add(this.label6);
        this.tabPage3.Controls.Add(this.label5);
        this.tabPage3.Controls.Add(this.label4);
        this.tabPage3.Controls.Add(this.label3);
        this.tabPage3.Controls.Add(this.label2);
        this.tabPage3.Location = new System.Drawing.Point(4, 30);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Size = new System.Drawing.Size(475, 216);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "Upload";
        this.tabPage3.ToolTipText = "Set upload settings to remote server";
        // 
        // ftpDirTxtBox
        // 
        this.ftpDirTxtBox.Location = new System.Drawing.Point(163, 140);
        this.ftpDirTxtBox.Name = "ftpDirTxtBox";
        this.ftpDirTxtBox.Size = new System.Drawing.Size(307, 27);
        this.ftpDirTxtBox.TabIndex = 11;
        // 
        // ftpPortTxtBox
        // 
        this.ftpPortTxtBox.Location = new System.Drawing.Point(163, 107);
        this.ftpPortTxtBox.Name = "ftpPortTxtBox";
        this.ftpPortTxtBox.Size = new System.Drawing.Size(307, 27);
        this.ftpPortTxtBox.TabIndex = 10;
        this.ftpPortTxtBox.Text = "21";
        // 
        // ftpPassTxtBox
        // 
        this.ftpPassTxtBox.Location = new System.Drawing.Point(163, 74);
        this.ftpPassTxtBox.Name = "ftpPassTxtBox";
        this.ftpPassTxtBox.Size = new System.Drawing.Size(307, 27);
        this.ftpPassTxtBox.TabIndex = 9;
        this.ftpPassTxtBox.UseSystemPasswordChar = true;
        // 
        // ftpUserTxtBox
        // 
        this.ftpUserTxtBox.Location = new System.Drawing.Point(163, 41);
        this.ftpUserTxtBox.Name = "ftpUserTxtBox";
        this.ftpUserTxtBox.Size = new System.Drawing.Size(307, 27);
        this.ftpUserTxtBox.TabIndex = 8;
        // 
        // ftpSettingsBtn
        // 
        this.ftpSettingsBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ftpSettingsBtn.Location = new System.Drawing.Point(325, 173);
        this.ftpSettingsBtn.Name = "ftpSettingsBtn";
        this.ftpSettingsBtn.Size = new System.Drawing.Size(145, 37);
        this.ftpSettingsBtn.TabIndex = 7;
        this.ftpSettingsBtn.Text = "save settings";
        this.ftpSettingsBtn.UseVisualStyleBackColor = true;
        this.ftpSettingsBtn.Click += new System.EventHandler(this.ftpSettingsBtn_Click_1);
        // 
        // ftptestConnectionbutton
        // 
        this.ftptestConnectionbutton.Location = new System.Drawing.Point(174, 173);
        this.ftptestConnectionbutton.Name = "ftptestConnectionbutton";
        this.ftptestConnectionbutton.Size = new System.Drawing.Size(145, 37);
        this.ftptestConnectionbutton.TabIndex = 6;
        this.ftptestConnectionbutton.Text = "test connection";
        this.ftptestConnectionbutton.UseVisualStyleBackColor = true;
        this.ftptestConnectionbutton.Click += new System.EventHandler(this.ftptestConnectionbutton_Click);
        // 
        // ftpHostTxtBox
        // 
        this.ftpHostTxtBox.Location = new System.Drawing.Point(163, 11);
        this.ftpHostTxtBox.Name = "ftpHostTxtBox";
        this.ftpHostTxtBox.Size = new System.Drawing.Size(307, 27);
        this.ftpHostTxtBox.TabIndex = 5;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(24, 143);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(133, 19);
        this.label6.TabIndex = 4;
        this.label6.Text = "Initial Directory (./)";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(64, 110);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(93, 19);
        this.label5.TabIndex = 3;
        this.label5.Text = "Remote Port:";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(28, 77);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(129, 19);
        this.label4.TabIndex = 2;
        this.label4.Text = "Remote Password:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(24, 44);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(133, 19);
        this.label3.TabIndex = 1;
        this.label3.Text = "Remote Username:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(18, 14);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(139, 19);
        this.label2.TabIndex = 0;
        this.label2.Text = "Remote Host Name:";
        // 
        // tabPage4
        // 
        this.tabPage4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.tabPage4.Controls.Add(this.saveGlobalSettingsBtn);
        this.tabPage4.Controls.Add(this.KillCheckbox);
        this.tabPage4.Controls.Add(this.ShowMessagesCheckbox);
        this.tabPage4.Controls.Add(this.AllowPluginsCheckbox);
        this.tabPage4.Controls.Add(this.HideUponLaunchCheckbox);
        this.tabPage4.Controls.Add(this.startOnWindowsLoadCheckBox);
        this.tabPage4.Location = new System.Drawing.Point(4, 30);
        this.tabPage4.Name = "tabPage4";
        this.tabPage4.Size = new System.Drawing.Size(475, 216);
        this.tabPage4.TabIndex = 3;
        this.tabPage4.Text = "Settings";
        this.tabPage4.ToolTipText = "Set global application settings";
        // 
        // saveGlobalSettingsBtn
        // 
        this.saveGlobalSettingsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        this.saveGlobalSettingsBtn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.saveGlobalSettingsBtn.ForeColor = System.Drawing.Color.DarkGreen;
        this.saveGlobalSettingsBtn.Location = new System.Drawing.Point(125, 177);
        this.saveGlobalSettingsBtn.Name = "saveGlobalSettingsBtn";
        this.saveGlobalSettingsBtn.Size = new System.Drawing.Size(221, 31);
        this.saveGlobalSettingsBtn.TabIndex = 5;
        this.saveGlobalSettingsBtn.Text = "Save Global Settings";
        this.saveGlobalSettingsBtn.UseVisualStyleBackColor = false;
        this.saveGlobalSettingsBtn.Click += new System.EventHandler(this.saveGlobalSettingsBtn_Click);
        // 
        // KillCheckbox
        // 
        this.KillCheckbox.AutoSize = true;
        this.KillCheckbox.Location = new System.Drawing.Point(23, 146);
        this.KillCheckbox.Name = "KillCheckbox";
        this.KillCheckbox.Size = new System.Drawing.Size(48, 23);
        this.KillCheckbox.TabIndex = 4;
        this.KillCheckbox.Text = "Kill";
        this.KillCheckbox.UseVisualStyleBackColor = true;
        // 
        // ShowMessagesCheckbox
        // 
        this.ShowMessagesCheckbox.AutoSize = true;
        this.ShowMessagesCheckbox.Location = new System.Drawing.Point(23, 117);
        this.ShowMessagesCheckbox.Name = "ShowMessagesCheckbox";
        this.ShowMessagesCheckbox.Size = new System.Drawing.Size(294, 23);
        this.ShowMessagesCheckbox.TabIndex = 3;
        this.ShowMessagesCheckbox.Text = "Show program essages in a message box";
        this.ShowMessagesCheckbox.UseVisualStyleBackColor = true;
        // 
        // AllowPluginsCheckbox
        // 
        this.AllowPluginsCheckbox.AutoSize = true;
        this.AllowPluginsCheckbox.Location = new System.Drawing.Point(23, 88);
        this.AllowPluginsCheckbox.Name = "AllowPluginsCheckbox";
        this.AllowPluginsCheckbox.Size = new System.Drawing.Size(380, 23);
        this.AllowPluginsCheckbox.TabIndex = 2;
        this.AllowPluginsCheckbox.Text = "Allow plugins to gather information about your system";
        this.AllowPluginsCheckbox.UseVisualStyleBackColor = true;
        // 
        // HideUponLaunchCheckbox
        // 
        this.HideUponLaunchCheckbox.AutoSize = true;
        this.HideUponLaunchCheckbox.Location = new System.Drawing.Point(23, 59);
        this.HideUponLaunchCheckbox.Name = "HideUponLaunchCheckbox";
        this.HideUponLaunchCheckbox.Size = new System.Drawing.Size(284, 23);
        this.HideUponLaunchCheckbox.TabIndex = 1;
        this.HideUponLaunchCheckbox.Text = "Hide instantly upon launch of program. ";
        this.HideUponLaunchCheckbox.UseVisualStyleBackColor = true;
        // 
        // startOnWindowsLoadCheckBox
        // 
        this.startOnWindowsLoadCheckBox.AutoSize = true;
        this.startOnWindowsLoadCheckBox.Location = new System.Drawing.Point(23, 30);
        this.startOnWindowsLoadCheckBox.Name = "startOnWindowsLoadCheckBox";
        this.startOnWindowsLoadCheckBox.Size = new System.Drawing.Size(307, 23);
        this.startOnWindowsLoadCheckBox.TabIndex = 0;
        this.startOnWindowsLoadCheckBox.Text = "Start this program when Windows boots up";
        this.startOnWindowsLoadCheckBox.UseVisualStyleBackColor = true;
        // 
        // tabPage5
        // 
        this.tabPage5.Location = new System.Drawing.Point(4, 30);
        this.tabPage5.Name = "tabPage5";
        this.tabPage5.Size = new System.Drawing.Size(475, 216);
        this.tabPage5.TabIndex = 4;
        this.tabPage5.Text = "Log";
        this.tabPage5.ToolTipText = "Check log files";
        this.tabPage5.UseVisualStyleBackColor = true;
        // 
        // main
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        this.ClientSize = new System.Drawing.Size(483, 250);
        this.Controls.Add(this.tabControl1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "main";
        this.Opacity = 0.9;
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.Text = "Skimpt v 1.01";
        this.TopMost = true;
        this.Load += new System.EventHandler(this.main_Load);
        this.Shown += new System.EventHandler(this.main_Shown);
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.randomnameoptions.ResumeLayout(false);
        this.randomnameoptions.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.tabPage3.ResumeLayout(false);
        this.tabPage3.PerformLayout();
        this.tabPage4.ResumeLayout(false);
        this.tabPage4.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.Button saveFileSettingBtn;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox fileLocationTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    public System.Windows.Forms.TextBox mainProgramMessage;
    private System.Windows.Forms.TextBox ftpHostTxtBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ftpDirTxtBox;
    private System.Windows.Forms.TextBox ftpPortTxtBox;
    private System.Windows.Forms.TextBox ftpPassTxtBox;
    private System.Windows.Forms.TextBox ftpUserTxtBox;
    private System.Windows.Forms.Button ftpSettingsBtn;
    private System.Windows.Forms.Button ftptestConnectionbutton;
    private GroupBox randomnameoptions;
    private RadioButton filenameasrandomoption;
    private RadioButton filenameasdateoption;
    private Button unhookButton;
    private Button toggleCamButton;
    public Rectangle CameraCoords;
    private CheckBox AllowPluginsCheckbox;
    private CheckBox HideUponLaunchCheckbox;
    private CheckBox startOnWindowsLoadCheckBox;
    private Button saveGlobalSettingsBtn;
    private CheckBox KillCheckbox;
    private CheckBox ShowMessagesCheckbox;
    #endregion

    #region Global public/private Variables

    private KeyboardHook KeyboardHookInstance;
    private bool isBusy = false;
    public bool _cameraMode = false;
    public bool _highlightMode = false;
    private Button browseButton;
    private FontDialog fontDialog1;
    private Label updateMessageLabel;
    private Button startHighlightModeBtn;
    private static Skimpt.Properties.Settings mySettings = new Skimpt.Properties.Settings();

    #endregion

    #region Delegates
    private delegate void ShowToastFormInvoker(string filename);

    #endregion

    #region Properties
    public bool ToggleCameraMode { get { return _cameraMode; } set { _cameraMode = value; } }

    #endregion

    #region Construtor
    public main()
    {
        //constructor.
        //dont delete this line. It creates all the GUI stuff.
        //Check the main.designer.cs to see GUI code.
        InitializeComponent();

        //The following sets up a hook as soon as the program is launched.
        KeyboardHookInstance = new KeyboardHook();
        KeyboardHookInstance.KeyIntercepted += new KeyboardHookCaptureHandler(KeyboardHookInstance_KeyIntercepted);

        //The following checks for a update
        BackgroundWorker bg = new BackgroundWorker();
        bg.WorkerReportsProgress = false;
        bg.DoWork += new DoWorkEventHandler(bg_DoWork);
        bg.RunWorkerAsync();
    }

    /// <summary>
    /// This function is invoked when RunWorkerAsync is called in the constructor.
    /// It runs on a seperate thread to check for a program update.
    /// </summary>
    void bg_DoWork(object sender, DoWorkEventArgs e)
    {
        int curVer;
        autoupdater.GetLatestVersion();
        curVer = Convert.ToInt32(Application.ProductVersion.Replace(".", string.Empty));

        if (autoupdater.GetLatestVersion() > curVer)
        {
            updateMessageLabel.Invoke(new MethodInvoker(ShowUpdateLabel));
        }
    }


    #endregion

    #region KeyboardShortCut Pressed


    /// <summary>
    /// This function is an event handler for the KeyIntercepted.
    /// It intercepts ALL keys from the keyboard input from the buffer.
    /// </summary>
    /// <param name="keyboardEvents">Contains the Key Enum, and the Key Code</param>
    void KeyboardHookInstance_KeyIntercepted(KeyboardHookEventArgs keyboardEvents)
    {
        if (keyboardEvents.PressedKey == Keys.PrintScreen)
        {
            takeSnapShot();
        }

        if (keyboardEvents.PressedKey == Keys.F8)
        {
            this.Visible = !this.Visible;
        }
    }

    #endregion

    #region Private Functions
    /// <summary>
    /// This validates the inputbox and checks if we have zero length.
    /// The inputbox is shown when the user chooses to specify a filename
    /// rather then randomly renaming it.
    /// </summary>
    private void inputBox_Validating(object sender, InputBoxValidatingArgs argE)
    {
        if (argE.Text.Trim().Length == 0)
        {
            //if the text is not valid, cancel the event. 
            argE.Cancel = true;
            argE.Message = "Required";
        }
    }

    /// <summary>
    /// This function, when executed, shows the toast form
    /// with animation. 
    /// </summary>
    /// <param name="filename">Full path needed to send to toast form</param>
    private void ShowToastForm(string filename)
    {
        //create a new random instance.
        Random rand = new Random();
        //create a new toastform instance.
        toastform slice = new toastform(System.IO.Path.Combine(mySettings.fileLocationSetting.ToString(), filename) + ".jpg");
        slice.Show();
        isBusy = false;
        rand = null;
    }

    /// <summary>
    /// This function, when executed, displays the
    /// hidden "update" label. It gets the update from
    /// google code. A seperate function is required because 
    /// a delegate is used to access this function.
    /// </summary>
    private void ShowUpdateLabel()
    {
        updateMessageLabel.Visible = true;
    }

    /// <summary>
    /// This function takes a snapshop. 
    /// If the camera is on, it only takes a specified window area.
    /// </summary>
    private void takeSnapShot()
    {
        Bitmap PictureTaken = null; //local variable for the captured Bitmap
        string filename = string.Empty; //local variable for filename
        if (!isBusy)
        {
            isBusy = true;
            //check if its a valid file and that the directory exists
            if (!String.IsNullOrEmpty(mySettings.fileLocationSetting.ToString()) || System.IO.Directory.Exists(mySettings.fileLocationSetting.ToString()))
            {

                //Check if user wants random filename
                if (mySettings.randomFileNameSetting)
                {
                    //check to see if they want randomized letters
                    //or current date and time.
                    if (mySettings.fileasdatesetting)
                        filename = utilities.GetRandomFileName();
                    else
                        filename = System.IO.Path.GetRandomFileName();
                }
                else
                {
                    //user has chosen to specify their own filename.
                    //Show the input box to get data.
                    InputBoxResult result = InputBox.Show("Enter Filename", "Filename Entry", String.Empty, new InputBoxValidatingHandler(inputBox_Validating));
                    if (result.OK)
                        filename = result.Text;
                    else
                        filename = System.IO.Path.GetRandomFileName(); //if the input box fails, randomize the filename.                    
                    result = null;
                }

                //clean the input incase it has an extension.
                filename = System.IO.Path.GetFileNameWithoutExtension(filename);
                
                //if camera mode is on
                if (_cameraMode)
                {
                    //try block to prevent errors
                    try
                    {
                        //take picture
                        PictureTaken = ScreenCapture.CaptureDeskTopRectangle(CameraCoords, CameraCoords.Width, CameraCoords.Height);
                        //save the file
                        PictureTaken.Save(System.IO.Path.Combine(mySettings.fileLocationSetting.ToString(), filename) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        //set the program message.
                        utilities.SetProgramMessage("Picture Saved", mainProgramMessage);
                        //invoke toast form to display picture options
                        this.Invoke(new ShowToastFormInvoker(ShowToastForm), filename);
                    }
                    catch (Exception ex)
                    {
                        //image capture failed.
                        //we were unable to save file.                        
                        if (mySettings.showErrorMessagesSetting)
                            MessageBox.Show("Unable to save file", "Error", MessageBoxButtons.OK);
                        isBusy = false;
                        utilities.SetProgramMessage(ex.Message, mainProgramMessage);
                    }
                    finally
                    {
                        if (PictureTaken != null)
                        {
                            PictureTaken.Dispose();
                            PictureTaken = null;
                        }

                    }
                }
                else
                {
                    //Camera mode is turned off, so we do the whole screen.
                    try
                    {

                        //PictureTaken = ScreenCapture.GetDesktopWindowCaptureAsBitmap();
                        //PictureTaken.Save(System.IO.Path.Combine(mySettings.fileLocationSetting.ToString(), filename) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        SkimptImage ski = new SkimptImage();
                        ski.ImageFormat = new JPGFormat();
                        ski.CaptureDesktop(CameraCoords);           
                     
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.Source.ToString() );
                        Console.WriteLine(ex.StackTrace.ToString());

                        //we were unable to save file.                        
                        if (mySettings.showErrorMessagesSetting)
                            MessageBox.Show("Unable to save file", "Error", MessageBoxButtons.OK);

                        isBusy = false;
                        utilities.SetProgramMessage(ex.Message, mainProgramMessage);
                    }
                    finally
                    {
                        if (PictureTaken != null)
                        {
                            PictureTaken.Dispose();
                            PictureTaken = null;
                        }

                    }
                }

                isBusy = false; //last of the code is executed. 
            }
            else
            {
                //filepath is not valid
                if (mySettings.showErrorMessagesSetting)
                    MessageBox.Show("File location not found", "Error", MessageBoxButtons.OK);

                isBusy = false;
                utilities.SetProgramMessage("File location not found", mainProgramMessage);

            }

        }

    }


    #endregion

    #region Settings Related Functions

    /// <summary>
    /// This function loads all the settings in the appropriate textboxes
    /// </summary>
    private void LoadSettings()
    {

        if (mySettings.randomFileNameSetting)
            this.radioButton1.Checked = true;
        else
            this.radioButton2.Checked = true;

        //check if a valid path exists.
        if (mySettings.fileLocationSetting != String.Empty && 
            System.IO.Directory.Exists (mySettings.fileLocationSetting))
        {
            this.fileLocationTextBox.Text = mySettings.fileLocationSetting;
        }
        else
        {
            //valid path does not exist. 
            mySettings.fileLocationSetting = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            mySettings.Save();
            this.fileLocationTextBox.Text = mySettings.fileLocationSetting;      

        }
        this.ftpHostTxtBox.Text = mySettings.ftphostSetting;
        this.ftpPassTxtBox.Text = mySettings.ftppasswordSetting;
        this.ftpUserTxtBox.Text = mySettings.ftpusernameSetting;
        this.ftpDirTxtBox.Text = mySettings.ftpdirectorySetting;
        this.ftpPortTxtBox.Text = mySettings.ftpportSetting.ToString();

    }
    /// <summary>
    /// The file SaveSettings button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void saveFileSettingBtn_Click(object sender, EventArgs e)
    {
        mySettings.fileLocationSetting = fileLocationTextBox.Text;
        if (radioButton1.Checked)
            mySettings.randomFileNameSetting = true;
        else if (radioButton2.Checked)
            mySettings.randomFileNameSetting = false;
        else
            mySettings.randomFileNameSetting = true;
        mySettings.Save();
    }

    /// <summary>
    /// The FTP SaveSettings button is clicked
    /// </summary>  
    private void ftpSettingsBtn_Click_1(object sender, EventArgs e)
    {
        mySettings.ftphostSetting = ftpHostTxtBox.Text;
        mySettings.ftpusernameSetting = ftpUserTxtBox.Text;
        mySettings.ftppasswordSetting = ftpPassTxtBox.Text;
        mySettings.ftpdirectorySetting = ftpDirTxtBox.Text;
        mySettings.ftpportSetting = Convert.ToInt32(ftpPortTxtBox.Text);
        mySettings.ftpOKsettings = false;
    }

    /// <summary>
    /// This function tests the FTP connection if valid values are given
    /// </summary>
    private void ftptestConnectionbutton_Click(object sender, EventArgs e)
    {
        //simulate save button so settings are stored in xml file
        ftpSettingsBtn.PerformClick();
        try
        {
            FTP f = new FTP(mySettings.ftphostSetting.ToString(), ".", mySettings.ftpusernameSetting, mySettings.ftppasswordSetting, mySettings.ftpportSetting);
            f.ChangeDirectory(mySettings.ftpdirectorySetting);
            mySettings.ftpOKsettings = true;
            mySettings.Save();
            MessageBox.Show("Test Successfull");
        }
        catch (Exception ex)
        {
            mySettings.ftpOKsettings = false;
            mySettings.Save();
            MessageBox.Show(ex.Message + Environment.NewLine + "Test Failed");
        }


    }

    /// <summary>
    /// This function is an event handler for the SaveGlobalSettings 
    /// button click. If its pressed it saves the global settings 
    /// to the XML file.
    /// </summary>
    private void saveGlobalSettingsBtn_Click(object sender, EventArgs e)
    {
        mySettings.hideOnLoad = HideUponLaunchCheckbox.Checked;
        mySettings.showErrorMessagesSetting = ShowMessagesCheckbox.Checked;


        //set or delete the registry key upon Windows Startup.
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        if (startOnWindowsLoadCheckBox.Checked)
        {
            rkApp.SetValue("Skimpt", Application.ExecutablePath.ToString());
        }
        else
        {
            rkApp.DeleteValue("Skimpt", false);
        }

        mySettings.Save();
    }



    #endregion

    #region Form Events

    /// <summary>
    /// This function is an event handler for when the form 
    /// loads. It is run after the constructor.   
    /// </summary>
    private void main_Load(object sender, EventArgs e)
    {
        if (mySettings.hideOnLoad)
            this.Hide();
        //When the form loads, load up all settings.
        LoadSettings();

        //check if new version is available.

    }

    /// <summary>
    /// This function is an event handler which unhooks the 
    /// Keyboard Intercepting. Clicking this will not cause the
    /// event to fire in the future.
    /// </summary>
    private void unhookButton_Click(object sender, EventArgs e)
    {

        //run the UnHookKey method. If it returns true,
        //display message to user.
        if (KeyboardHookInstance.UnHookKey())
        {
            if (mySettings.showErrorMessagesSetting)
                MessageBox.Show("prtscr unhooked from program");
        }
    }
    /// <summary>
    /// This function is an event handler for when the toggle camera 
    /// button is clicked.
    /// </summary>
    private void toggleCamButton_Click(object sender, EventArgs e)
    {

        _cameraMode = !_cameraMode;
        bool _alreadyopen = false;

        if (_cameraMode)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item is MainCropForm)
                    _alreadyopen = true;


            }
            if (!_alreadyopen)
            {
                MainCropForm mc = new MainCropForm(this);
                mc.Show();
                this.Hide();
            }

        }

    }

    private void startHighlightModeBtn_Click(object sender, EventArgs e)
    {
        _highlightMode = !_highlightMode;
        bool _alreadyopen = false;

        if(_highlightMode)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item is MainCropForm)
                    _alreadyopen = true;
            }
            if(!_alreadyopen)
            {
                MainCropForm mc = new MainCropForm(this);
                mc.Show();
                this.Hide();
            }

        }
    }

    /// <summary>
    /// This function is an event handler for the Radiobutton1_Checkchanged
    /// If its changed, and if its true, then show the
    /// options for random file renaming.
    /// </summary>
    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton1.Checked)
        {
            randomnameoptions.Visible = true;
        }
        else
        {
            randomnameoptions.Visible = false;
        }

    }
    /// <summary>
    /// This function is an event handler for the FolderBrowse button
    /// It opens a new instance of the folderBrowser to allow
    /// the user to select a path 
    /// </summary>
    private void browseButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        fbd.ShowDialog();
        if (System.IO.Directory.Exists(fbd.SelectedPath))
            fileLocationTextBox.Text = fbd.SelectedPath;
        saveFileSettingBtn.PerformClick(); //click the save button
        fbd.Dispose();
        fbd = null;
    }


    /// <summary>
    /// This function occurs when the form is first SHOWN. 
    /// This function happens after the load event.
    /// </summary>
    private void main_Shown(object sender, EventArgs e)
    {
        if (mySettings.hideOnLoad)
            this.Hide();
    }


    #endregion

  

 
}
