using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RobotAppearanceProvider
    {
        private static FB_RobotAppearanceProvider _Instance;
        public static FB_RobotAppearanceProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RobotAppearanceProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/RobotAppearance.txt";
        protected Dictionary<int, FB_RobotAppearance> mData = new Dictionary<int, FB_RobotAppearance>();
        private List<FB_RobotAppearance> mListData = new List<FB_RobotAppearance>();
        public List<FB_RobotAppearance> ListData
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
        public FB_RobotAppearance GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RobotAppearance);
        }
        public Dictionary<int, FB_RobotAppearance> GetData()
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
            if (!FB_RobotAppearanceContainer.FB_RobotAppearanceContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RobotAppearanceContainer.GetRootAsFB_RobotAppearanceContainer(bb);
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
