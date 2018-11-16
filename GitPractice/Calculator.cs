using System;
using System.Collections.Generic;
using System.Text;

namespace GitPractice
{
    class Calculator
    {
        //Create project and git init
        //Initial commit : git commit -m"Initial Commit"
        //Made Changes
        //Made more commits
        //pushed to gitHub: git push
        //created a branch: git branch BranchName
        //Switched to branch: git checkout BranchName
        //Pull Request
        //Merged the pull request
        //Pulled updated master branch : git pull
        //Deleted branch: git branch -d BranchName



        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
