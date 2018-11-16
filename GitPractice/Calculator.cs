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


        public int Add(int n, int x)
        {
            return n + x;
        }

        public int Subtract(int n, int x)
        {
            return n - x;
        }

        public double Multiply(double n, double x)
        {
            return n * x;
        }

        public double Divide(double n, double x)
        {
            if(x == 0)
            {
                return 0;
            }
            return n / x; 
        }
    }
}
