using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LocalNotificationProvider
    {
        private static FB_LocalNotificationProvider _Instance;
        public static FB_LocalNotificationProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LocalNotificationProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/LocalNotification.txt";
        protected Dictionary<int, FB_LocalNotification> mData = new Dictionary<int, FB_LocalNotification>();
        private List<FB_LocalNotification> mListData = new List<FB_LocalNotification>();
        public List<FB_LocalNotification> ListData
        {
            get
            {
                var id = this.GetHashCode();
                if (mListData.Count <= 0)
                {
                    mListData.AddRange(mData.Values);
                }
                return mListData;
            }
        }
        public FB_LocalNotification GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LocalNotification);
        }
        public Dictionary<int, FB_LocalNotification> GetData()
        {
            return mData;
        }
        public void LoadFromFile(string dataPath)
        {
            this.LoadData(new ByteBuffer(File.ReadAllBytes(dataPath)));
        }
        public void LoadFromMemory(byte[] dataBytes)
        {
            this.LoadData(new ByteBuffer(dataBytes));
        }
        public void LoadData(ByteBuffer bb) {
            if (!FB_LocalNotificationContainer.FB_LocalNotificationContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LocalNotificationContainer.GetRootAsFB_LocalNotificationContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Id, item);
            }
            var id = this.GetHashCode();
        }
        public void Clear()
        {
            mData.Clear();
            mListData.Clear();
        }
    }
}
