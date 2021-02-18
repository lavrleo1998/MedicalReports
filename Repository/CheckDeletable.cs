﻿using Domain;

namespace Repository
{
    public static class CheckDeletable
    {
        public static bool IsDeleted(object model)
        {
            if (model is IDeletableObject)
            {
                var deletable = model as IDeletableObject;
                return deletable.IsDeleted;
            }
            else
                return false;
        }
    }
}
