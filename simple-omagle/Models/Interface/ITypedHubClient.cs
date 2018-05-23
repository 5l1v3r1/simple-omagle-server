using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiDenemesi.Models.Interface
{
    public interface ITypedHubClient
    {
        Task callDeclined(User user, string donus);
        Task BroadcastMessage(string type, string payload);
        Task gotMessageFromServer(object mesaj);
        Task callDeclined(string connectionId,string donus);
        Task callDeclined(string connectionId, string donus, string userName);
        Task incomingCall(User user);
        Task callEnded(string connectionId, string donus);
        Task receiveSignal(User user, string donus);
        Task updateUserList(List<User> users);

        Task callAccepted(User user);

    }
}
