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


        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public double Multiply(double first, double second)
        {
            return first * second;
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
