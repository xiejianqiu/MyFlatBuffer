using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaCSChapterProvider
    {
        private static FB_ShenWangZhanJiaCSChapterProvider _Instance;
        public static FB_ShenWangZhanJiaCSChapterProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaCSChapterProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ShenWangZhanJiaCSChapter.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaCSChapter> mData = new Dictionary<int, FB_ShenWangZhanJiaCSChapter>();
        private List<FB_ShenWangZhanJiaCSChapter> mListData = new List<FB_ShenWangZhanJiaCSChapter>();
        public List<FB_ShenWangZhanJiaCSChapter> ListData
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
        public FB_ShenWangZhanJiaCSChapter GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaCSChapter);
        }
        public Dictionary<int, FB_ShenWangZhanJiaCSChapter> GetData()
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
            if (!FB_ShenWangZhanJiaCSChapterContainer.FB_ShenWangZhanJiaCSChapterContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaCSChapterContainer.GetRootAsFB_ShenWangZhanJiaCSChapterContainer(bb);
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
