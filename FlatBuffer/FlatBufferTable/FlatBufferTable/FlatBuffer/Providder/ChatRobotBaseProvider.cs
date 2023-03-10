using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChatRobotBaseProvider
    {
        private static FB_ChatRobotBaseProvider _Instance;
        public static FB_ChatRobotBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChatRobotBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ChatRobotBase.txt";
        protected Dictionary<int, FB_ChatRobotBase> mData = new Dictionary<int, FB_ChatRobotBase>();
        private List<FB_ChatRobotBase> mListData = new List<FB_ChatRobotBase>();
        public List<FB_ChatRobotBase> ListData
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
        public FB_ChatRobotBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChatRobotBase);
        }
        public Dictionary<int, FB_ChatRobotBase> GetData()
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
            if (!FB_ChatRobotBaseContainer.FB_ChatRobotBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChatRobotBaseContainer.GetRootAsFB_ChatRobotBaseContainer(bb);
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
