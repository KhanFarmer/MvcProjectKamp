using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendBox();
        void AddMessage(Message message);
        Message GetByID(int id);
        void DeleteMessage(int id);
        void DeleteMessage(Message message);
        void UpdateMessage(Message message);
    }
}
