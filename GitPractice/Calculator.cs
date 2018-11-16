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



        public int Add(int firstNumberToAdd, int secondNumberToAdd)
        {
            return firstNumberToAdd + secondNumberToAdd;
        }

        public int Subtract(int numberToSubrtractFrom, int numberToSubtract)
        {
            return numberToSubrtractFrom - numberToSubtract;
        }

        public double Multiply(double firstNumberToMultiply, double secondNumberToMultiply)
        {
            return firstNumberToMultiply * secondNumberToMultiply;
        }

        public int Divide(int numberToDivideFrom, int numberToDivide)
        {
            return numberToDivideFrom / numberToDivide;
        }
    }
}
