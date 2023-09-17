using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CopySceneMoNengFeiXuProvider
    {
        private static FB_CopySceneMoNengFeiXuProvider _Instance;
        public static FB_CopySceneMoNengFeiXuProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CopySceneMoNengFeiXuProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CopySceneMoNengFeiXu.txt";
        protected Dictionary<int, FB_CopySceneMoNengFeiXu> mData = new Dictionary<int, FB_CopySceneMoNengFeiXu>();
        private List<FB_CopySceneMoNengFeiXu> mListData = new List<FB_CopySceneMoNengFeiXu>();
        public List<FB_CopySceneMoNengFeiXu> ListData
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
        public FB_CopySceneMoNengFeiXu GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CopySceneMoNengFeiXu);
        }
        public Dictionary<int, FB_CopySceneMoNengFeiXu> GetData()
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
            if (!FB_CopySceneMoNengFeiXuContainer.FB_CopySceneMoNengFeiXuContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CopySceneMoNengFeiXuContainer.GetRootAsFB_CopySceneMoNengFeiXuContainer(bb);
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
