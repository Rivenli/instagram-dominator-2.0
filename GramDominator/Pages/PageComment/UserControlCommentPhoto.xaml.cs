﻿using BaseLib;
using BaseLibID;
using Comment;
<<<<<<< HEAD
using FaceDominator3._0.PageWall;
using FirstFloor.ModernUI.Windows.Controls;
using Globussoft;
using GramDominator.CustomUserControls;
using HashTagsManager;
using System;
using System.Collections.Generic;
using System.Data;
=======
using FirstFloor.ModernUI.Windows.Controls;
using Globussoft;
using System;
using System.Collections.Generic;
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GramDominator.Pages.Pagecomment
{
    /// <summary>
    /// Interaction logic for UserControlCommentPhoto.xaml
    /// </summary>
    public partial class UserControlCommentPhoto : UserControl
    {
        public UserControlCommentPhoto()
        {
            InitializeComponent();
<<<<<<< HEAD
            Account_Report();
        }

        public void closeEvent()
        { 
        }


=======
        }

>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
        private void rdo_CommentInput_SingleUser_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                ClGlobul.commentMsgList.Clear();
                ClGlobul.CommentIdsForMSG.Clear();
<<<<<<< HEAD
                txtMessage_Comment_LoadMessages.Clear();
                txtMessage_Comment_PhotoID.Clear();               
=======
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
            }
            catch { }
            try
            {
                btnMessage_Comment_LoadMessages.Visibility = Visibility.Hidden;
                btnMessage_Comment_LoadPhotoID.Visibility = Visibility.Hidden;
               
            }
            catch { };
            try
            {
                txtMessage_Comment_LoadMessages.IsReadOnly = false;
                txtMessage_Comment_PhotoID.IsReadOnly = false;
            }
            catch { };
        }

        private void rdo_CommentInput_MultipleUser_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
<<<<<<< HEAD
                ClGlobul.commentMsgList.Clear();
                ClGlobul.CommentIdsForMSG.Clear();
                txtMessage_Comment_LoadMessages.Clear();
                txtMessage_Comment_PhotoID.Clear();          
            }
            catch(Exception ex)
            {
                GlobusLogHelper.log.Info("Error :" + ex.StackTrace);
            }
            try
            {
=======
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
                btnMessage_Comment_LoadMessages.Visibility = Visibility.Visible;
                btnMessage_Comment_LoadPhotoID.Visibility = Visibility.Visible;
               
            }
            catch { };
            try
            {
                txtMessage_Comment_LoadMessages.IsReadOnly = true;
                txtMessage_Comment_PhotoID.IsReadOnly = true;
            }
            catch { };
        }

        private void btnMessage_Comment_LoadMessages_click(object sender, RoutedEventArgs e)
        {
            try
            {
                Comment_idprogress.IsIndeterminate = true;
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.DefaultExt = ".txt";
                dlg.Filter = "Text documents (.txt)|*.txt";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    txtMessage_Comment_LoadMessages.Text = dlg.FileName.ToString();
                    readcommentFile(dlg.FileName);
                }
                //  GlobusLogHelper.log.Info(" [ " + objFollower.lstOfUserIDToFollow.Count + "] UserId Uploaded");
                 Comment_idprogress.IsIndeterminate = false;
            }
            catch { };
        }


        public void readcommentFile(string commentFilePath)
        {
            try
            {
                ClGlobul.commentMsgList.Clear();
                List<string> MSGlist = GlobusFileHelper.ReadFile((string)commentFilePath);
                foreach (string MSGlist_item in MSGlist)
                {
                    //add Photo Id's In maine photo list...
                    ClGlobul.commentMsgList.Add(MSGlist_item);
                }
                ClGlobul.commentMsgList = ClGlobul.commentMsgList.Distinct().ToList();
                GlobusLogHelper.log.Info("[ " + DateTime.Now + " ] => [ " + ClGlobul.commentMsgList.Count + " Messages Uploaded. ]");
            }
            catch (Exception ex)
            {
                
            }
        }


        private void btnMessage_Comment_LoadPhotoID_click(object sender, RoutedEventArgs e)
        {
            try
            {
                Comment_idprogress.IsIndeterminate = true;
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.DefaultExt = ".txt";
                dlg.Filter = "Text documents (.txt)|*.txt";
                Nullable<bool> result = dlg.ShowDialog();
                if (result == true)
                {
                    txtMessage_Comment_PhotoID.Text = dlg.FileName.ToString();
                    readcommentidFile(dlg.FileName);
                    
                }
                //  GlobusLogHelper.log.Info(" [ " + objFollower.lstOfUserIDToFollow.Count + "] UserId Uploaded");
                Comment_idprogress.IsIndeterminate = false;
            }
            catch { };
        }

        public void readcommentidFile(string commentidFilePath)
        {
            try
            {
                ClGlobul.CommentIdsForMSG.Clear();
                //Read Data From Selected File ....
                List<string> commentidlist = GlobusFileHelper.ReadFile((string)commentidFilePath);
                foreach (string commentidlist_item in commentidlist)
                {
                    //add Comment Id's In Globol Comment Id List ...
                    ClGlobul.CommentIdsForMSG.Add(commentidlist_item);
                }
                ClGlobul.CommentIdsForMSG = ClGlobul.CommentIdsForMSG.Distinct().ToList();
               
                GlobusLogHelper.log.Info("[ " + DateTime.Now + " ] => [ " + ClGlobul.CommentIdsForMSG.Count + " Image IDs Uploaded. ]");
            }
            catch (Exception ex)
            {
                
            }
        }








        Utils objUtils = new Utils();
        private void btnMessage_Comment_Start_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (IGGlobals.listAccounts.Count > 0)
                {
                    try
                    {

                        if (string.IsNullOrEmpty(txtMessage_Comment_LoadMessages.Text) && string.IsNullOrEmpty(txtMessage_Comment_PhotoID.Text))
                        {
<<<<<<< HEAD
                            GlobusLogHelper.log.Info("Please Upload Comment Message/PhotoId");
                            ModernDialog.ShowMessage("Please Upload Comment Message/PhotoId", "Upload Notice", MessageBoxButton.OK);
=======
                            GlobusLogHelper.log.Info("Please Upload Comment Message");
                            ModernDialog.ShowMessage("Please Upload Comment Message", "Upload Message", MessageBoxButton.OK);
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        GlobusLogHelper.log.Error("Error : " + ex.StackTrace);
                    }
                    ObjCommentManager.isStopCommentPoster = false;
                    ObjCommentManager.lstThreadsCommentPoster.Clear();

                    Regex checkNo = new Regex("^[0-9]*$");

                    int processorCount = objUtils.GetProcessor();

                    int threads = 25;

                    int maxThread = 25 * processorCount;
                    try
                    {
                        try
                        {
                            CommentManager.minDelayCommentPoster = Convert.ToInt32(txt_Comment_delaystart.Text);
                            CommentManager.maxDelayCommentPoster = Convert.ToInt32(txt_Comment_delaystop.Text);
                            CommentManager.Nothread_comment = Convert.ToInt32(txt_Comment_thread.Text);
                        }
                        catch (Exception ex)
                        {
<<<<<<< HEAD
                            GlobusLogHelper.log.Info("Enter in Correct Format/Fill all Field");
                            ModernDialog.ShowMessage("Enter in Correct Format/Fill all Field", "Error", MessageBoxButton.OK);                           
=======
                            GlobusLogHelper.log.Info("Enter in Correct Format");
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
                            return;
                        }

                     if(rdo_CommentInput_MultipleUser.IsChecked == true)
                     {
<<<<<<< HEAD
                         CommentManager.CommentPhoto_ID = string.Empty;
                         CommentManager.message_comment = string.Empty;
=======
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
                         CommentManager.CommentPhoto_ID_path = txtMessage_Comment_PhotoID.Text;
                         CommentManager.message_comment_path = txtMessage_Comment_LoadMessages.Text;
                     }
                        if(rdo_CommentInput_SingleUser.IsChecked==true)
                        {
<<<<<<< HEAD
                            CommentManager.CommentPhoto_ID_path = string.Empty;
                            CommentManager.message_comment_path = string.Empty;
=======
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
                            CommentManager.CommentPhoto_ID = txtMessage_Comment_PhotoID.Text;
                            CommentManager.message_comment = txtMessage_Comment_LoadMessages.Text;
                        }                                                                 
                       
                    }
                    catch (Exception ex)
                    {
                        GlobusLogHelper.log.Error("Error : " + ex.StackTrace);
                    }

                    if (!string.IsNullOrEmpty(txt_Comment_thread.Text) && checkNo.IsMatch(txt_Comment_thread.Text))
                    {
                        threads = Convert.ToInt32(txt_Comment_thread.Text);
                    }

                    if (threads > maxThread)
                    {
                        threads = 25;
                    }
                    ObjCommentManager.NoOfThreadsCommentPoster = threads;

<<<<<<< HEAD
                    if (hash_managerlibry.DivideByUser == true)
                    {
                        Thread ForDivideUser = new Thread(ObjCommentManager.startCommentdividedataUser);
                        ForDivideUser.Start();
                        GlobusLogHelper.log.Info("------ Comment Proccess Started ------");
                    }
                    else
                    {
                        if (hash_managerlibry.DivideEqual == true)
                        {
                            Thread ForDivideEqual = new Thread(ObjCommentManager.StartCommentDividedatabyequally);
                            ForDivideEqual.Start();
                            GlobusLogHelper.log.Info("------ Comment Proccess Started ------");
                        }
                        else
                        {

                            Thread CommentPosterThread = new Thread(ObjCommentManager.StartCommentPoster);
                            CommentPosterThread.Start();
                            GlobusLogHelper.log.Info("------ Comment Proccess Started ------");
                        }
                    }
=======

                   
                    Thread CommentPosterThread = new Thread(ObjCommentManager.StartCommentPoster);
                    CommentPosterThread.Start();
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
                }
                else
                {
                    GlobusLogHelper.log.Info("Please Load Accounts !");
                    GlobusLogHelper.log.Debug("Please Load Accounts !");

                }
            }
            catch (Exception ex)
            {
                GlobusLogHelper.log.Error("Error : " + ex.StackTrace);
            }
        }

        CommentManager ObjCommentManager = new CommentManager();

        private void btnMessage_Comment_Stop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
<<<<<<< HEAD
                Thread stopComment = new Thread(stopMultiThreadComment);
                stopComment.Start();
            }
            catch (Exception ex)
            {
                GlobusLogHelper.log.Error("Error : " + ex.StackTrace);
            }
         
        }

        public void stopMultiThreadComment()
        {
            try
            {
                ObjCommentManager.isStopCommentPoster = true;
=======
                ObjCommentManager.isStopCommentPoster = true;

>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
                List<Thread> lstTemp = new List<Thread>();
                lstTemp = ObjCommentManager.lstThreadsCommentPoster.Distinct().ToList();

                foreach (Thread item in lstTemp)
                {
                    try
                    {
                        item.Abort();
                        ObjCommentManager.lstThreadsCommentPoster.Remove(item);
                    }
                    catch (Exception ex)
                    {
                        //Thread.ResetAbort();
                        GlobusLogHelper.log.Error("Error : " + ex.StackTrace);
                    }
                }
<<<<<<< HEAD
=======

>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
            }
            catch (Exception ex)
            {
                GlobusLogHelper.log.Error("Error : " + ex.StackTrace);
            }
<<<<<<< HEAD
=======

>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
            GlobusLogHelper.log.Info("Process Stopped !");
            GlobusLogHelper.log.Debug("Process Stopped !");
        }

        private void btnMessage_Clear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtMessage_Comment_PhotoID.Text = string.Empty;
                txtMessage_Comment_LoadMessages.Text = string.Empty;
                txt_Comment_thread.Text = string.Empty;
                txt_Comment_delaystart.Text = string.Empty;
                txt_Comment_delaystop.Text = string.Empty;
            }
            catch(Exception ex)
            {
                GlobusLogHelper.log.Info("Error : " + ex.StackTrace);
            }
        }

<<<<<<< HEAD


        QueryManager Qm = new QueryManager();
        public void Account_Report()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Account_User");
                dt.Columns.Add("Photo_Id");
                dt.Columns.Add("Message");
                dt.Columns.Add("DateTime");
                dt.Columns.Add("Status");
              
                int counter = 0;
                DataSet ds = null;
                try
                {
                    ds = Qm.SelectAccountreport("CommentModule");
                }
                catch(Exception ex)
                {
                    GlobusLogHelper.log.Info("Error :" + ex.StackTrace);
                }
                foreach(DataRow ds_item in ds.Tables[0].Rows)
                {
                    try
                    {

                        string Account_User = ds_item.ItemArray[2].ToString();
                        string Photo_Id = ds_item[3].ToString();
                        string Message = ds_item[4].ToString();
                        string DateTime = ds_item[12].ToString();
                        string Status = ds_item[7].ToString();
                        dt.Rows.Add(Account_User, Photo_Id, Message,DateTime,Status);


                    }
                    catch { };


                }

              //  DataView dv = ds.Tables[0].DefaultView;
            //    dv.AllowNew = false;
                DataView dv;
                try
                {
                  //  dv = dt.DefaultView;
                   // dv.AllowNew = false;

                }
                catch { };
               
                this.Dispatcher.Invoke(new Action(delegate
                {
                    dtGrdComment_Comment_AccountsReport.ItemsSource = dt.DefaultView;

                }));
                
            }
            catch(Exception ex)
            {
                GlobusLogHelper.log.Info("Error : " + ex.StackTrace);
            }
        }

        private void RefreshAccRepotComment_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Account_Report();
            }
            catch(Exception ex)
            {
                GlobusLogHelper.log.Info("Error :" + ex.StackTrace);
            }
        }

        private void DeleteAccRepotComment_Click(object sender, RoutedEventArgs e)
        {
            var result = ModernDialog.ShowMessage("Are You Sure Delete Loaded Account ?? ", "Delete Account", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                QueryExecuter.deleteQueryforAccountReport("CommentModule");
                IGGlobals.listAccounts.Clear();
                Account_Report();
            }
        }

        private void ExportAccReptComment_Click(object sender, RoutedEventArgs e)
        {

        }

        public void DeleteAccountReport_Comment()
        {
            try
            {

            }
            catch(Exception ex)
            {
                GlobusLogHelper.log.Info("Error : " + ex.StackTrace);
            }
        }
=======
>>>>>>> 040a8d35fce59f25e2f75d75646c50226d83374f
       
    }
}
