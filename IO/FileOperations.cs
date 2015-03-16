//
//
// (c) 2015 Samaritan Pawn IDE - Source Code
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samaritan.IO
{
    class FileOperations
    {
        public void LoadProject(string path)
        {

        }

        public void GetTreeNodeFilePath(TreeNode node)
        {

        }

        public void CreateNewProject(string projectName, string path)
        {

        }

        public TreeNode CreateRootFolder(string folderName, TreeView view)
        {
            var rootNode = new TreeNode();
            rootNode.Text = folderName;
            rootNode.Tag = "Folder";
            view.Nodes.Add(rootNode);
            return rootNode;
        }

        public TreeNode CreateSubFolder(TreeNode rootFolder, string subFolderName, TreeView view)
        {
            var subNode = new TreeNode();
            subNode.Text = subFolderName;
            subNode.Tag = "Folder";
            rootFolder.Nodes.Add(subNode);
            return subNode;
        }
    }
}
