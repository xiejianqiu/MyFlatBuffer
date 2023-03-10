// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ZhuangBeiXunBao : Table {
  public static FB_ZhuangBeiXunBao GetRootAsFB_ZhuangBeiXunBao(ByteBuffer _bb) { return GetRootAsFB_ZhuangBeiXunBao(_bb, new FB_ZhuangBeiXunBao()); }
  public static FB_ZhuangBeiXunBao GetRootAsFB_ZhuangBeiXunBao(ByteBuffer _bb, FB_ZhuangBeiXunBao obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ZhuangBeiXunBao __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighDropBox { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowDropBox { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowTime { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighTime { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BaseRandom { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AddRandom { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedItemId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TreasureAddMoney { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ZhuangBeiXunBao> CreateFB_ZhuangBeiXunBao(FlatBufferBuilder builder,
      int Id = 0,
      int MenPai = -1,
      int DropLevel = -1,
      int HighDropBox = -1,
      int LowDropBox = -1,
      int LowTime = -1,
      int HighTime = -1,
      int BaseRandom = -1,
      int AddRandom = -1,
      int NeedItemId = -1,
      int TreasureAddMoney = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(13);
    FB_ZhuangBeiXunBao.AddItemNumList(builder, ItemNumList);
    FB_ZhuangBeiXunBao.AddItemIDList(builder, ItemIDList);
    FB_ZhuangBeiXunBao.AddTreasureAddMoney(builder, TreasureAddMoney);
    FB_ZhuangBeiXunBao.AddNeedItemId(builder, NeedItemId);
    FB_ZhuangBeiXunBao.AddAddRandom(builder, AddRandom);
    FB_ZhuangBeiXunBao.AddBaseRandom(builder, BaseRandom);
    FB_ZhuangBeiXunBao.AddHighTime(builder, HighTime);
    FB_ZhuangBeiXunBao.AddLowTime(builder, LowTime);
    FB_ZhuangBeiXunBao.AddLowDropBox(builder, LowDropBox);
    FB_ZhuangBeiXunBao.AddHighDropBox(builder, HighDropBox);
    FB_ZhuangBeiXunBao.AddDropLevel(builder, DropLevel);
    FB_ZhuangBeiXunBao.AddMenPai(builder, MenPai);
    FB_ZhuangBeiXunBao.AddId(builder, Id);
    return FB_ZhuangBeiXunBao.EndFB_ZhuangBeiXunBao(builder);
  }

  public static void StartFB_ZhuangBeiXunBao(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, -1); }
  public static void AddDropLevel(FlatBufferBuilder builder, int DropLevel) { builder.AddInt(2, DropLevel, -1); }
  public static void AddHighDropBox(FlatBufferBuilder builder, int HighDropBox) { builder.AddInt(3, HighDropBox, -1); }
  public static void AddLowDropBox(FlatBufferBuilder builder, int LowDropBox) { builder.AddInt(4, LowDropBox, -1); }
  public static void AddLowTime(FlatBufferBuilder builder, int LowTime) { builder.AddInt(5, LowTime, -1); }
  public static void AddHighTime(FlatBufferBuilder builder, int HighTime) { builder.AddInt(6, HighTime, -1); }
  public static void AddBaseRandom(FlatBufferBuilder builder, int BaseRandom) { builder.AddInt(7, BaseRandom, -1); }
  public static void AddAddRandom(FlatBufferBuilder builder, int AddRandom) { builder.AddInt(8, AddRandom, -1); }
  public static void AddNeedItemId(FlatBufferBuilder builder, int NeedItemId) { builder.AddInt(9, NeedItemId, -1); }
  public static void AddTreasureAddMoney(FlatBufferBuilder builder, int TreasureAddMoney) { builder.AddInt(10, TreasureAddMoney, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(11, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(12, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ZhuangBeiXunBao> EndFB_ZhuangBeiXunBao(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ZhuangBeiXunBao>(o);
  }
};

public sealed class FB_ZhuangBeiXunBaoContainer : Table {
  public static FB_ZhuangBeiXunBaoContainer GetRootAsFB_ZhuangBeiXunBaoContainer(ByteBuffer _bb) { return GetRootAsFB_ZhuangBeiXunBaoContainer(_bb, new FB_ZhuangBeiXunBaoContainer()); }
  public static FB_ZhuangBeiXunBaoContainer GetRootAsFB_ZhuangBeiXunBaoContainer(ByteBuffer _bb, FB_ZhuangBeiXunBaoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ZhuangBeiXunBaoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ZhuangBeiXunBaoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ZhuangBeiXunBao GetItems(int j) { return GetItems(new FB_ZhuangBeiXunBao(), j); }
  public FB_ZhuangBeiXunBao GetItems(FB_ZhuangBeiXunBao obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ZhuangBeiXunBaoContainer> CreateFB_ZhuangBeiXunBaoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ZhuangBeiXunBaoContainer.AddItems(builder, items);
    return FB_ZhuangBeiXunBaoContainer.EndFB_ZhuangBeiXunBaoContainer(builder);
  }

  public static void StartFB_ZhuangBeiXunBaoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ZhuangBeiXunBao>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ZhuangBeiXunBaoContainer> EndFB_ZhuangBeiXunBaoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ZhuangBeiXunBaoContainer>(o);
  }
  public static void FinishFB_ZhuangBeiXunBaoContainerBuffer(FlatBufferBuilder builder, Offset<FB_ZhuangBeiXunBaoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
