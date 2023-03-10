using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TeamPostionProvider
    {
        private static FB_TeamPostionProvider _Instance;
        public static FB_TeamPostionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TeamPostionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/TeamPostion.txt";
        protected Dictionary<int, FB_TeamPostion> mData = new Dictionary<int, FB_TeamPostion>();
        private List<FB_TeamPostion> mListData = new List<FB_TeamPostion>();
        public List<FB_TeamPostion> ListData
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
        public FB_TeamPostion GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TeamPostion);
        }
        public Dictionary<int, FB_TeamPostion> GetData()
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
            if (!FB_TeamPostionContainer.FB_TeamPostionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TeamPostionContainer.GetRootAsFB_TeamPostionContainer(bb);
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
