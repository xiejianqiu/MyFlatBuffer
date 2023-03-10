using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChatRobotContentProvider
    {
        private static FB_ChatRobotContentProvider _Instance;
        public static FB_ChatRobotContentProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChatRobotContentProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ChatRobotContent.txt";
        protected Dictionary<int, FB_ChatRobotContent> mData = new Dictionary<int, FB_ChatRobotContent>();
        private List<FB_ChatRobotContent> mListData = new List<FB_ChatRobotContent>();
        public List<FB_ChatRobotContent> ListData
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
        public FB_ChatRobotContent GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChatRobotContent);
        }
        public Dictionary<int, FB_ChatRobotContent> GetData()
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
            if (!FB_ChatRobotContentContainer.FB_ChatRobotContentContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChatRobotContentContainer.GetRootAsFB_ChatRobotContentContainer(bb);
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