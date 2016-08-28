// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Version 4.4.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;

namespace KryptonExplorer
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            kryptonNavigator.SelectedIndex = 0;
            kryptonNavigatorToolkit.SelectedIndex = 0;
        }

        private void linkKryptonBorderEdge_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonBorderEdgeExamples.exe"); }
            catch
            {
                // ignored
            }
        }

        private void linkKryptonButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonButtonExamples.exe"); }
            catch
            {
                // ignored
            }
        }

        private void linkKryptonCheckBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonCheckBoxExamples.exe"); }
            catch
            {
                // ignored
            }
        }

        private void linkKryptonCheckButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonCheckButtonExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonDropButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonDropButtonExamples.exe"); }
            catch
            {
                // ignored
            }
        }

        private void linkKryptonColorButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonColorButtonExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonCheckSet_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonCheckSetExamples.exe"); }
            catch {  // ignored 
            }
        }

        private void linkKryptonContextMenu_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonContextMenuExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonDataGridView_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonDataGridViewExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonForm_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonFormExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonGroup_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonGroupExamples.exe"); }
            catch {  // ignored 
            }
        }

        private void linkKryptonGroupBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonGroupBoxExamples.exe"); }
            catch {  // ignored 
            }
        }

        private void linkKryptonHeader_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonHeaderExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonHeaderGroup_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonHeaderGroupExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonLabel_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonLabelExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonWrapLabel_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonWrapLabelExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonCommand_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonCommandExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonLinkLabel_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonLinkLabelExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonListBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonListBoxExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonCheckedListBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonCheckedListBoxExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonMaskedTextBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonMaskedTextBoxExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonPalette_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonPaletteExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonPanel_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonPanelExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonSeparator_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonSeparatorExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonRadioButton_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonRadioButtonExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptobTrackBar_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonTrackBarExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonSplitContainer_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonSplitContainerExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonComboBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonComboBoxExamples.exe"); }
            catch {  // ignored 
            }
        }

        private void linkKryptonTextBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonTextBoxExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonRichTextBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonRichTextBoxExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonNumericUpDown_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonNumericUpDownExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonDomainUpDown_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonDomainUpDownExamples.exe"); }
            catch {  // ignored 
            }
        }

        private void linkKryptonBreadCrumb_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonBreadCrumbExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonDateTimePicker_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonDateTimePickerExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonMonthCalendar_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonMonthCalendarExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonInputBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonInputBoxExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonMessageBox_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonMessageBoxExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonTaskDialog_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonTaskDialogExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonTreeView_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonTreeViewExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkInputForm_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\InputForm.exe"); }
            catch {  // ignored 
            }
        }

        private void linkThreePaneApplicationBasic_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ThreePaneApplicationBasic.exe"); }
            catch {  // ignored
            }
        }

        private void linkThreePaneApplicationExtended_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ThreePaneApplicationExtended.exe"); }
            catch {  // ignored
            }
        }

        private void linkMDIApplication_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\MDIApplication.exe"); }
            catch {  // ignored
            }
        }

        private void linkCustomControlUsingPalettes_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\CustomControlUsingPalettes.exe"); }
            catch {  // ignored
            }
        }

        private void linkCustomControlUsingRenderers_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\CustomControlUsingRenderers.exe"); }
            catch {  // ignored
            }
        }

        private void linkExpandingSplitters_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ExpandingHeaderGroupsSplitters.exe"); }
            catch {  // ignored 
            }
        }

        private void linkExpandingDockStyle_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ExpandingHeaderGroupsDockStyle.exe"); }
            catch {  // ignored
            }
        }

        private void linkExpandingHeaderStack_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ExpandingHeaderGroupsStack.exe"); }
            catch {  // ignored 
            }
        }

        private void linkChildControlStack_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ChildControlStack.exe"); }
            catch {  // ignored
            }
        }

        private void linkLabelButtonSpecPlayground_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ButtonSpecPlayground.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorModes_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\NavigatorModes.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorPalettes_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\NavigatorPalettes.exe"); }
            catch {  // ignored
            }
        }

        private void linkOrientationAndAlignment_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\OrientationPlusAlignment.exe"); }
            catch {  // ignored
            }
        }

        private void linkSinglelineAndMultiline_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\SinglelinePlusMultiline.exe"); }
            catch {  // ignored
            }
        }

        private void linkTabBorderStyles_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\TabBorderStyles.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorPopupPages_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\PopupPages.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorPerTabButtons_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\PerTabButtons.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorTooltips_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\NavigatorToolTips.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorContextMenus_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\NavigatorContextMenus.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorPlayground_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\NavigatorPlayground.exe"); }
            catch {  // ignored
            }
        }

        private void linkContextualTabs_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ContextualTabs.exe"); }
            catch {  // ignored
            }
        }

        private void linkKeyTipsTabs_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KeyTipsAndKeyboardAccess.exe"); }
            catch {  // ignored
            }
        }

        private void labelAutoShrinkingGroups_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\AutoShrinkingGroups.exe"); }
            catch {  // ignored 
            }
        }

        private void labelQuickAccessToolbar_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\QuickAccessToolbar.exe"); }
            catch {  // ignored 
            }
        }

        private void linkRibbonGallery_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\RibbonGallery.exe"); }
            catch {  // ignored 
            }
        }

        private void linkRibbonToolTips_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\RibbonToolTips.exe"); }
            catch {  // ignored 
            }
        }

        private void linkRibbonControls_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\RibbonControls.exe"); }
            catch {  // ignored
            }
        }

        private void linkKryptonGallery_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\KryptonGalleryExamples.exe"); }
            catch {  // ignored
            }
        }

        private void linkApplicationMenu_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ApplicationMenu.exe"); }
            catch {  // ignored 
            }
        }

        private void linkOutlookMailClone_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\OutlookMailClone.exe"); }
            catch {  // ignored 
            }
        }

        private void linkRibbonAndNavigator_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\RibbonAndNavigatorAndWorkspace.exe"); }
            catch {  // ignored
            }
        }

        private void linkMDIRibbon_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\MDIRibbon.exe"); }
            catch {  // ignored
            }
        }

        private void linkExpandingPages_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ExpandingPages.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorBasicEvents_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\BasicEvents.exe"); }
            catch {  // ignored 
            }
        }

        private void linkNavigatorUserPageCreation_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\UserPageCreation.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorOneNoteTabs_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\OneNoteTabs.exe"); }
            catch {  // ignored
            }
        }

        private void linkNavigatorOutlookMockup_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\OutlookMockup.exe"); }
            catch {  // ignored
            }
        }

        private void linkWorkspaceCellModes_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\WorkspaceCellModes.exe"); }
            catch {  // ignored
            }
        }

        private void linkWorkspaceCellLayout_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\WorkspaceCellLayout.exe"); }
            catch {  // ignored
            }
        }

        private void linkWorkspacePersistence_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\WorkspacePersistence.exe"); }
            catch {  // ignored
            }
        }

        private void linkCellMaximizeAndRestore_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\CellMaximizeAndRestore.exe"); }
            catch {  // ignored
            }
        }

        private void linkBasicPageDragAndDrop_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\BasicPageDragAndDrop.exe"); }
            catch {  // ignored 
            }
        }

        private void linkAdvancedPageDragAndDrop_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\AdvancedPageDragAndDrop.exe"); }
            catch {  // ignored
            }
        }

        private void memoEditor_Clicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\MemoEditor.exe"); }
            catch {  // ignored
            }
        }

        private void linkStandardDocking_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\StandardDocking.exe"); }
            catch {  // ignored 
            }
        }

        private void linkMultiControlDocking_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\MultiControlDocking.exe"); }
            catch {  // ignored
            }
        }

        private void linkExternalDragToDocking_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\ExternalDragToDocking.exe"); }
            catch {  // ignored
            }
        }


        private void linkNavigatorAndFloatingWindows_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\NavigatorAndFloatingWindows.exe"); }
            catch {  // ignored
            }
        }

        private void linkDockingPersistence_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\DockingPersistence.exe"); }
            catch {  // ignored
            }
        }

        private void linkDockingFlags_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\DockingFlags.exe"); }
            catch {  // ignored 
            }
        }

        private void linkDockingCustomized_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\DockingCustomized.exe"); }
            catch {  // ignored
            }
        }

        private void linkPaletteDesigner_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\PaletteDesigner.exe"); }
            catch {  // ignored
            }
        }

        private void linkPaletteUpgradeTool_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@".\PaletteUpgradeTool.exe"); }
            catch {  // ignored
            }
        }

        private void linkToolkitChangeList_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@"..\Documents\Krypton Toolkit Change List.doc"); }
            catch {  // ignored
            }
        }

        private void linkDockingChangeList_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@"..\Documents\Krypton Docking Change List.doc"); }
            catch
            {
                // ignored
            }
        }

        private void linkRibbonChangeList_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@"..\Documents\Krypton Ribbon Change List.doc"); }
            catch
            {
                // ignored
            }
        }

        private void linkNavigatorChangeList_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@"..\Documents\Krypton Navigator Change List.doc"); }
            catch
            {
                // ignored
            }
        }

        private void linkWorkspaceChangeList_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@"..\Documents\Krypton Workspace Change List.doc"); }
            catch
            {
                // ignored
            }
        }

        private void linkDocumentation_LinkClicked(object sender, EventArgs e)
        {
            try { Process.Start(@"..\Help\Krypton Suite Help.pdf"); }
            catch
            {
                // ignored
            }
        }

        private void linkToolkitExamplesSource2010_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                              @"\Component Factory\Krypton\Source\Krypton Toolkit Examples\Krypton Toolkit Examples.sln";

                Process.Start(path);
            }
            catch
            {
                // ignored
            }
        }

        private void linkToolkitExamples2Source2010_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                              @"\Component Factory\Krypton\Source\Krypton Toolkit Examples\Krypton Toolkit Examples II.sln";

                Process.Start(path);
            }
            catch
            {
                // ignored
            }
        }

        private void linkDockingExamplesSource2010_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                              @"\Component Factory\Krypton\Source\Krypton Docking Examples\Krypton Docking Examples.sln";

                Process.Start(path);
            }
            catch
            {
                // ignored
            }
        }

        private void linkWorkspaceExamplesSource2010_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                              @"\Component Factory\Krypton\Source\Krypton Workspace Examples\Krypton Workspace Examples.sln";

                Process.Start(path);
            }
            catch
            {
                // ignored
            }
        }

        private void linkNavigatorExamplesSource2010_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                              @"\Component Factory\Krypton\Source\Krypton Navigator Examples\Krypton Navigator Examples.sln";

                Process.Start(path);
            }
            catch
            {
                // ignored
            }
        }

        private void linkRibbonExamplesSource2010_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                              @"\Component Factory\Krypton\Source\Krypton Ribbon Examples\Krypton Ribbon Examples.sln";

                Process.Start(path);
            }
            catch
            {
                // ignored
            }
        }


        private void linkBlog_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"https://github.com/Cocotteseb/Krypton");
            }
            catch
            {
                // ignored
            }
        }

        private void kryptonButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
