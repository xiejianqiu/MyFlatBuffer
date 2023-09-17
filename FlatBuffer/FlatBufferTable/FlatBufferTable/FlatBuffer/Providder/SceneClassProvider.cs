using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SceneClassProvider
    {
        private static FB_SceneClassProvider _Instance;
        public static FB_SceneClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SceneClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SceneClass.txt";
        protected Dictionary<int, FB_SceneClass> mData = new Dictionary<int, FB_SceneClass>();
        private List<FB_SceneClass> mListData = new List<FB_SceneClass>();
        public List<FB_SceneClass> ListData
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
        public FB_SceneClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SceneClass);
        }
        public Dictionary<int, FB_SceneClass> GetData()
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
            if (!FB_SceneClassContainer.FB_SceneClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SceneClassContainer.GetRootAsFB_SceneClassContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.SceneID, item);
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
