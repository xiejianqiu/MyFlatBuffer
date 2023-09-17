using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChatExpressionProvider
    {
        private static FB_ChatExpressionProvider _Instance;
        public static FB_ChatExpressionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChatExpressionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ChatExpression.txt";
        protected Dictionary<int, FB_ChatExpression> mData = new Dictionary<int, FB_ChatExpression>();
        private List<FB_ChatExpression> mListData = new List<FB_ChatExpression>();
        public List<FB_ChatExpression> ListData
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
        public FB_ChatExpression GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChatExpression);
        }
        public Dictionary<int, FB_ChatExpression> GetData()
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
            if (!FB_ChatExpressionContainer.FB_ChatExpressionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChatExpressionContainer.GetRootAsFB_ChatExpressionContainer(bb);
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
