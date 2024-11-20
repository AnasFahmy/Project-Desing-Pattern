using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.State
{
    //Originator
    public class Document
    {
        public DocumentState State { get; set; }

        public UserRoles CurrentUserRole { get; set; }

        public void Publish(){
            if(State == DocumentState.Draft)
            {
                State = DocumentState.Moderation;
            }
            else if(State == DocumentState.Moderation)
            {
                if(CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentState.published;
                }
            }
            else if(State == DocumentState.published)
            {
                //Do nothing
            }
        }
    }   
}