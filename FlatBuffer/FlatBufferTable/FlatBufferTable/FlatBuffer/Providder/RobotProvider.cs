using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RobotProvider
    {
        private static FB_RobotProvider _Instance;
        public static FB_RobotProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RobotProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/Robot.txt";
        protected Dictionary<int, FB_Robot> mData = new Dictionary<int, FB_Robot>();
        private List<FB_Robot> mListData = new List<FB_Robot>();
        public List<FB_Robot> ListData
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
        public FB_Robot GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_Robot);
        }
        public Dictionary<int, FB_Robot> GetData()
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
            if (!FB_RobotContainer.FB_RobotContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RobotContainer.GetRootAsFB_RobotContainer(bb);
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
