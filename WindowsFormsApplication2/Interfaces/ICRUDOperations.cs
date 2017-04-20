using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public interface ICRUDOperations
    {
        bool save();

        bool update();

        bool delete();

        bool get();

        bool getAll();
    }
}
