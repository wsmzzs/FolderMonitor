using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace FolderMonitor
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存已监控过的路径进去历史路径方法
        /// </summary>
        /// <returns></returns>
        private void SavePathToConfig()
        {
            // 记录历史监控路径           
            string selectedMonitorPath = txtMonitorPath.Text;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection appSettings = config.AppSettings;
            string HistoryMonitorPaths = ConfigurationManager.AppSettings["HistoryMonitorPaths"];
            // 将监控历史路径分割成数组
            string[] MonitorPaths = HistoryMonitorPaths.Split('|');
            if (!MonitorPaths.Contains(selectedMonitorPath))// 如果选定的路径不在数组中，则添加它
            {
                if (string.IsNullOrEmpty(HistoryMonitorPaths))//如果历史路径为空，则直接设置为选定路径
                {
                    HistoryMonitorPaths = selectedMonitorPath;
                } else//如果历史路径不为空，添加到历史路径后面
                {
                    HistoryMonitorPaths += "|" + selectedMonitorPath;
                }
                // 保存更新后的历史路径
                appSettings.Settings["HistoryMonitorPaths"].Value = HistoryMonitorPaths;
            }
            if (txtBackCopyPath.Text != "")//如果备份文件夹路径不为空
            {
                //记录历史备份路径
                string selectedBackCopyPath = txtBackCopyPath.Text;
                string HistoryBackCopyPaths = ConfigurationManager.AppSettings["HistoryBackCopyPaths"];
                string[] BackCopyPaths = HistoryBackCopyPaths.Split('|');//将备份历史备份路径分割成数组
                if(!BackCopyPaths.Contains(selectedBackCopyPath))
                {
                    if(string.IsNullOrEmpty(HistoryBackCopyPaths))
                    {
                        HistoryBackCopyPaths = selectedBackCopyPath;
                    } else
                    {
                        HistoryBackCopyPaths += "|" + selectedBackCopyPath;
                    }
                    appSettings.Settings["HistoryBackCopyPaths"].Value = HistoryBackCopyPaths;
                }
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

        }

        private void picFolder1_Click(object sender, EventArgs e)
        {
            // 创建文件夹选择对话框
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // 设置对话框的标题和描述
                folderDialog.Description = "选择要监控的文件夹";
                folderDialog.ShowNewFolderButton = true; // 允许创建新文件夹

                // 如果用户点击了 "确定" 按钮
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // 获取所选文件夹的路径并设置到文本框中
                    txtMonitorPath.Text = folderDialog.SelectedPath;
                }
            }
        }
        
        private void picFolder2_Click(object sender, EventArgs e)
        {
            // 创建文件夹选择对话框
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // 设置对话框的标题和描述
                folderDialog.Description = "选择要监控的文件夹";
                folderDialog.ShowNewFolderButton = true; // 允许创建新文件夹

                // 如果用户点击了 "确定" 按钮
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // 获取所选文件夹的路径并设置到文本框中
                    txtBackCopyPath.Text = folderDialog.SelectedPath;
                }
            }
        }
        /// <summary>
        /// 开始监控按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartMonitor_Click(object sender, EventArgs e)
        {
            //判断监控路径是否为空，空则返回
            if (txtMonitorPath.Text == "")
            {
                MessageBox.Show("请填写您要监控的文件夹路径");
                return;
            }
                
            //判断备份路径是否为空，为空则直接进行显示删除;
            if(txtBackCopyPath.Text == "")
            {
                if (!showFile())
                    return;
                MonitorTimer.Start();
                btnStartMonitor.Appearance.BackColor = Color.Blue;
                DeleteFile();
                if (DeleteFile() == false)
                {
                    MessageBox.Show("删除出现异常！");
                    MonitorTimer.Stop();
                    btnStartMonitor.Appearance.BackColor = Color.LightSteelBlue;
                    showFile();
                }
                SavePathToConfig();

            } else
            {
                //不为空则先进行备选到指定路径再进行显示删除
                if (!showFile())
                {
                    return;
                }
                    
                MonitorTimer.Start();
                btnStartMonitor.Appearance.BackColor = Color.Blue;
                backUpCopy();
                if(backUpCopy() == false)
                {
                    MonitorTimer.Stop();
                    btnStartMonitor.Appearance.BackColor = Color.LightSteelBlue;
                    MessageBox.Show("备份出现异常");
                    return;
                }
                SavePathToConfig();
                showFile();
            }

        }
        /// <summary>
        /// 备份数据方法
        /// </summary>
        private bool backUpCopy()
        {            
            try
            {
                //获取监控路径文件夹信息
                string[] filesToMove = Directory.GetFiles(txtMonitorPath.Text);
                //如果下拉框值为空，则全部文件都进行备份
                if (txtMin.Text == "")
                {
                    // 备份每个文件
                    foreach (string filePath in filesToMove)
                    {
                        // 构建备份路径中的目标文件路径
                        string fileName = Path.GetFileName(filePath);
                        string destinationFilePath = Path.Combine(txtBackCopyPath.Text, fileName);
                        // 如果目标文件已经存在，则删除它
                        if (File.Exists(destinationFilePath))
                        {
                            try
                            {
                                File.Delete(destinationFilePath);
                            }
                            catch (Exception ex)
                            {
                                // 处理删除文件时的异常，可以记录错误信息或采取其他适当的措施
                                MonitorTimer.Stop();
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                        try
                        {
                            // 移动文件（或复制文件，取决于你的需求）
                            File.Move(filePath, destinationFilePath);
                        }
                        catch (Exception ex)
                        {
                            // 处理移动文件时的异常，可以记录错误信息或采取其他适当的措施
                            MonitorTimer.Stop();
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                }
                else    
                {
                    int minutesToKeep = Convert.ToInt32(txtMin.Text); // 获取comboBoxEdit1的值并转换为整数
                                                                     
                    // 下拉框有值，则遍历每一个路径，拿到每一个文件的修改时间信息，如果当今时间 - 修改时间 <= comboxedit.text分钟，则进行备份
                    DateTime minDateTime = DateTime.Now.AddMinutes(-minutesToKeep); // 获取指定分钟数前的时间
                    //定义一个字符串泛型集合存储符合条件要备份的文件
                    List<string> filesToCopy = new List<string>();
                    //选出符合条件的文件路径存入集合
                    foreach (string filePath in filesToMove)
                    {
                        FileInfo fileInfo = new FileInfo(filePath);

                        // 如果文件的修改时间早于minDateTime，则将其添加到待删除列表
                        if (fileInfo.LastWriteTime < minDateTime)
                        {
                            filesToCopy.Add(filePath);
                        }
                    }
                    //遍历集合，备份文件
                    foreach (string filePathToCopy in filesToCopy)
                    {
                        try
                        {
                            // 构建备份路径中的目标文件路径
                            string fileName = Path.GetFileName(filePathToCopy);
                            string destinationFilePath = Path.Combine(txtBackCopyPath.Text, fileName);
                            // 如果目标文件已经存在，则删除它
                            if (File.Exists(destinationFilePath))
                            {
                                try
                                {
                                    File.Delete(destinationFilePath);
                                }
                                catch (Exception ex)
                                {
                                    // 处理删除文件时的异常，可以记录错误信息或采取其他适当的措施
                                    MonitorTimer.Stop();
                                    MessageBox.Show(ex.Message);
                                    return false;
                                }
                            }
                            try
                            {
                                // 移动文件
                                File.Move(filePathToCopy, destinationFilePath);
                            }
                            catch (Exception ex)
                            {
                                // 处理移动文件时的异常，可以记录错误信息或采取其他适当的措施
                                MonitorTimer.Stop();
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                        catch (Exception ex)
                        {
                            // 处理删除文件时的异常
                            MonitorTimer.Stop();
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }

                }
                // 返回操作结果
                return true;
            
            }
            catch (Exception ex)
            {
                MonitorTimer.Stop();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 显示文件信息
        /// </summary>
        private bool showFile()
        {
            if (!CheckPath(txtMonitorPath.Text))//如果检测路径失败，返回假则return回去
            {
                MonitorTimer.Stop();
                return false;
            }
            if(!string.IsNullOrEmpty(txtBackCopyPath.Text))
            {
                if (!CheckPath(txtBackCopyPath.Text))//如果检测路径失败，返回假则return回去
                {
                    MonitorTimer.Stop();
                    return false;
                }
                if(txtBackCopyPath.Text == txtMonitorPath.Text)
                {
                    MonitorTimer.Stop();
                    MessageBox.Show("备份文件夹路径不能与监控文件夹路径相同！！！");
                    
                    return false;
                }
            }
            
            // 根据监控路径获取文件夹内的文件信息
            string[] files = Directory.GetFiles(txtMonitorPath.Text);
            // 清空ListView
            LVFile.Items.Clear();
            foreach (string filePath in files)
            {
                // 获取文件信息
                FileInfo fileInfo = new FileInfo(filePath);

                // 创建ListViewItem并添加到ListView
                ListViewItem item = new ListViewItem(fileInfo.Name); // 文件名称
                item.SubItems.Add(fileInfo.LastWriteTime.ToString()); // 修改日期
                item.SubItems.Add(fileInfo.Extension); // 文件类型
                item.SubItems.Add(fileInfo.Length.ToString()); // 文件大小（字节）

                LVFile.Items.Add(item);
            }
            return true;
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <returns></returns>
        private bool DeleteFile()
        {           
            try
            {
                    // 获取文件夹内的所有文件
                    string[] files = Directory.GetFiles(txtMonitorPath.Text);
                    //如果下拉框值值=''，则全部文件都进行删除
                    if (txtMin.Text == "")
                    {
                        // 删除每个文件
                        foreach (string filePath in files)
                        {
                            File.Delete(filePath);
                        }
                    }
                    else
                    {
                        int minutesToKeep = Convert.ToInt32(txtMin.Text); // 获取comboBoxEdit1的值并转换为整数
                                                                         //下拉框有值，则遍历每一个路径，拿到每一个文件的修改时间信息，如果当今时间-修改时间<=comboxedit.text分钟，则进行删除
                        DateTime minDateTime = DateTime.Now.AddMinutes(-minutesToKeep); // 获取指定分钟数前的时间
                                                                                        //定义一个字符串泛型集合存储符合条件要删除的文件
                        List<string> filesToDelete = new List<string>();
                        //选出符合条件的文件路径存入集合
                        foreach (string filePath in files)
                        {
                            FileInfo fileInfo = new FileInfo(filePath);

                            // 如果文件的修改时间早于minDateTime，则将其添加到待删除列表
                            if (fileInfo.LastWriteTime < minDateTime)
                            {
                                filesToDelete.Add(filePath);
                            }
                        }
                        //遍历集合，删除文件
                        foreach (string filePathToDelete in filesToDelete)
                        {
                            try
                            {
                                File.Delete(filePathToDelete);
                            }
                            catch (Exception ex)
                            {
                                // 处理删除文件时的异常
                                MonitorTimer.Stop();
                                MessageBox.Show(ex.Message);
                                return false;
                            }
                        }

                    }
                // 返回操作结果
                return true;

            }
            catch (Exception ex)
            {
                // 处理删除文件时的异常
                MonitorTimer.Stop();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void MonitorTimer_Tick(object sender, EventArgs e)
        {
            btnStartMonitor_Click(sender, e);
        }

        

        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            MonitorTimer.Stop();
            btnStartMonitor.Appearance.BackColor = Color.LightSteelBlue;
            this.Close();
        }

        

        /// <summary>
        /// 检测路径是否存在方法，如果不存在且路径合理则创建该文件夹
        /// </summary>
        /// <param name="CheckPath">路径字符串</param>
        private bool CheckPath(string CheckPath)
        {
            //检查文本框的路径是否合理，合理则检测是否存在，不存在则创建该文件夹
            if (!Directory.Exists(CheckPath))//(进入情况：1.该字符串路径不存在文件夹；2.文件名)
            {
                try
                    {
                    // 检查路径是否合法
                    if (!Path.IsPathRooted(CheckPath) || CheckPath.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
                    {
                        MonitorTimer.Stop();
                        // 路径无效，显示错误消息或采取其他适当的措施

                        MessageBox.Show("请输入有效的文件夹路径");
                        return false;
                    }
                    // 如果路径合理且是文件夹路径，则创建该文件夹
                    Directory.CreateDirectory(CheckPath);
                    } catch (Exception ex)
                    {
                        MonitorTimer.Stop();
                        MessageBox.Show(ex.Message);
                        return false;
                    } 
            }
            return true;
        }

        private void txtMonitorPath_EditValueChanged(object sender, EventArgs e)
        {
            MonitorTimer.Stop();
            btnStartMonitor.Appearance.BackColor = Color.LightSteelBlue;
        }

        private void txtMonitorPath_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            MonitorTimer.Stop();
            btnStartMonitor.Appearance.BackColor = Color.LightSteelBlue;
        }

        private void cbMin_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // 允许数字、退格键和删除键
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 阻止输入非数字字符
            }
        }

        /// <summary>
        /// 停止监控按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            MonitorTimer.Stop();
            btnStartMonitor.Appearance.BackColor = Color.LightSteelBlue;
        }

        private void index_Load(object sender, EventArgs e)
        {
            
            // 读取历史路径
            string HistoryMonitorPaths = ConfigurationManager.AppSettings["HistoryMonitorPaths"];
            string HistoryBackCopyPaths = ConfigurationManager.AppSettings["HistoryBackCopyPaths"];
            string[] Monitorpaths = HistoryMonitorPaths.Split('|');
            string[] BackCopyPaths = HistoryBackCopyPaths.Split('|');
            //把数组反转
            Array.Reverse(Monitorpaths);
            Array.Reverse(BackCopyPaths);
            if(Monitorpaths.Length > 5)
            {
                //如果长度大于5
                //取前五个元素
                for (int i = 0; i < 5; i++)
                {
                    txtMonitorPath.Items.Add(Monitorpaths[i]);
                    
                }
            }else
            {
                txtMonitorPath.Items.AddRange(Monitorpaths);
            }
            if (BackCopyPaths.Length > 5)
            {
                //如果长度大于5
                //取前五个元素
                for (int i = 0; i < 5; i++)
                {
                    txtBackCopyPath.Items.Add(BackCopyPaths[i]);

                }
            } else
            {
                txtBackCopyPath.Items.AddRange(BackCopyPaths);
            }
            

        }
    }
}
