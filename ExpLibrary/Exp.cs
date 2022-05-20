using System;
using System.Collections.Generic;
using System.Text;

//represents the workspace that all the classes fall under 
//name of project
namespace ExpLibrary
{
    //abstract class to extend from for all other classes 
    public abstract class Exp
    {
        //abstract string to be extended to other classes to be used
        //output class for display
        public abstract string outPutExp();
    }
}
