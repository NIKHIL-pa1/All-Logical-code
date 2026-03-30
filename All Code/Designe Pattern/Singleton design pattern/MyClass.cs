using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_design_pattern
{
    sealed public class MyClass
    {

        private MyClass()
        {

        }

        #region check condition for object is created or not
        // here object wil created every time in a memory whether singleton class will use or will not to be use so we will
        //  add condition in below method and modify objet and this method

        //private static MyClass instance;
        //public static MyClass GetInstance()
        //{
        //    if (instance == null)
        //        instance = new MyClass();

        //    return instance;
        //}

        #endregion

        #region tackle multithreading

        //now singleton designe pattern becomes failed in multithreading 
        //now suppose two threads are comming here and executing this code so both thread are comes here at a time 
        //and now both of them are checked if condition at a time so it will get a null instance so they creatd a two objects of this class
        //so avoiding this such a things we use a lock checking.

        private static MyClass instance;
        private static object instanceLock = new object();

        public static MyClass GetInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MyClass();
                    }
                }
            }
            return instance;
        }
        #endregion


        //private static readonly MyClass instance =  new MyClass();

        //Globle Access Poit Method

        // public static MyClass GetInstance() => instance;


        //below is another way

        //private  readonly MyClass instance =  new MyClass();

        //public static MyClass GetInstance()
        //{
        //    MyClass instances = new MyClass();
        //    return instances.instance;
        //}
    }
}
