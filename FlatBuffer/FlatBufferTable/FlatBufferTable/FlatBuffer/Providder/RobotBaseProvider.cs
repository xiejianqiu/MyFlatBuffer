using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RobotBaseProvider
    {
        private static FB_RobotBaseProvider _Instance;
        public static FB_RobotBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RobotBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RobotBase.txt";
        protected Dictionary<int, FB_RobotBase> mData = new Dictionary<int, FB_RobotBase>();
        private List<FB_RobotBase> mListData = new List<FB_RobotBase>();
        public List<FB_RobotBase> ListData
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
        public FB_RobotBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RobotBase);
        }
        public Dictionary<int, FB_RobotBase> GetData()
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
            if (!FB_RobotBaseContainer.FB_RobotBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RobotBaseContainer.GetRootAsFB_RobotBaseContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ID, item);
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
