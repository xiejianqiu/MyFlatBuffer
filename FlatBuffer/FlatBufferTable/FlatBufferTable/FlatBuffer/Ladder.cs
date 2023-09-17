// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Ladder : Table {
  public static FB_Ladder GetRootAsFB_Ladder(ByteBuffer _bb) { return GetRootAsFB_Ladder(_bb, new FB_Ladder()); }
  public static FB_Ladder GetRootAsFB_Ladder(ByteBuffer _bb, FB_Ladder obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Ladder __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int JiFen { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JiFenReward { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)300; } }
  public int ShenQiLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DescStrId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DIdShenQi { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DidShenQiShowId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DBangYuan { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DBangYin { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetDIdItemList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DIdItemListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDIdItemCountList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DIdItemCountListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int SIdShenQi { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SIdShenQiShowId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SBangYuan { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SBangYin { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetSIdItemList(int j) { int o = __offset(36); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SIdItemListLength { get { int o = __offset(36); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSIdItemCountList(int j) { int o = __offset(38); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SIdItemCountListLength { get { int o = __offset(38); return o != 0 ? __vector_len(o) : 0; } }
  public string RankBg { get { int o = __offset(40); return o != 0 ? __string(o + bb_pos) : null; } }
  public string RankIcon { get { int o = __offset(42); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_Ladder> CreateFB_Ladder(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int JiFen = 0,
      int JiFenReward = 300,
      int ShenQiLevel = -1,
      int DescStrId = -1,
      int DIdShenQi = -1,
      int DidShenQiShowId = -1,
      int DBangYuan = 0,
      int DBangYin = 0,
      VectorOffset DIdItemList = default(VectorOffset),
      VectorOffset DIdItemCountList = default(VectorOffset),
      int SIdShenQi = -1,
      int SIdShenQiShowId = -1,
      int SBangYuan = 0,
      int SBangYin = 0,
      VectorOffset SIdItemList = default(VectorOffset),
      VectorOffset SIdItemCountList = default(VectorOffset),
      StringOffset RankBg = default(StringOffset),
      StringOffset RankIcon = default(StringOffset)) {
    builder.StartObject(20);
    FB_Ladder.AddRankIcon(builder, RankIcon);
    FB_Ladder.AddRankBg(builder, RankBg);
    FB_Ladder.AddSIdItemCountList(builder, SIdItemCountList);
    FB_Ladder.AddSIdItemList(builder, SIdItemList);
    FB_Ladder.AddSBangYin(builder, SBangYin);
    FB_Ladder.AddSBangYuan(builder, SBangYuan);
    FB_Ladder.AddSIdShenQiShowId(builder, SIdShenQiShowId);
    FB_Ladder.AddSIdShenQi(builder, SIdShenQi);
    FB_Ladder.AddDIdItemCountList(builder, DIdItemCountList);
    FB_Ladder.AddDIdItemList(builder, DIdItemList);
    FB_Ladder.AddDBangYin(builder, DBangYin);
    FB_Ladder.AddDBangYuan(builder, DBangYuan);
    FB_Ladder.AddDidShenQiShowId(builder, DidShenQiShowId);
    FB_Ladder.AddDIdShenQi(builder, DIdShenQi);
    FB_Ladder.AddDescStrId(builder, DescStrId);
    FB_Ladder.AddShenQiLevel(builder, ShenQiLevel);
    FB_Ladder.AddJiFenReward(builder, JiFenReward);
    FB_Ladder.AddJiFen(builder, JiFen);
    FB_Ladder.AddName(builder, Name);
    FB_Ladder.AddID(builder, ID);
    return FB_Ladder.EndFB_Ladder(builder);
  }

  public static void StartFB_Ladder(FlatBufferBuilder builder) { builder.StartObject(20); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddJiFen(FlatBufferBuilder builder, int JiFen) { builder.AddInt(2, JiFen, 0); }
  public static void AddJiFenReward(FlatBufferBuilder builder, int JiFenReward) { builder.AddInt(3, JiFenReward, 300); }
  public static void AddShenQiLevel(FlatBufferBuilder builder, int ShenQiLevel) { builder.AddInt(4, ShenQiLevel, -1); }
  public static void AddDescStrId(FlatBufferBuilder builder, int DescStrId) { builder.AddInt(5, DescStrId, -1); }
  public static void AddDIdShenQi(FlatBufferBuilder builder, int DIdShenQi) { builder.AddInt(6, DIdShenQi, -1); }
  public static void AddDidShenQiShowId(FlatBufferBuilder builder, int DidShenQiShowId) { builder.AddInt(7, DidShenQiShowId, -1); }
  public static void AddDBangYuan(FlatBufferBuilder builder, int DBangYuan) { builder.AddInt(8, DBangYuan, 0); }
  public static void AddDBangYin(FlatBufferBuilder builder, int DBangYin) { builder.AddInt(9, DBangYin, 0); }
  public static void AddDIdItemList(FlatBufferBuilder builder, VectorOffset DIdItemListOffset) { builder.AddOffset(10, DIdItemListOffset.Value, 0); }
  public static VectorOffset CreateDIdItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDIdItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDIdItemCountList(FlatBufferBuilder builder, VectorOffset DIdItemCountListOffset) { builder.AddOffset(11, DIdItemCountListOffset.Value, 0); }
  public static VectorOffset CreateDIdItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDIdItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSIdShenQi(FlatBufferBuilder builder, int SIdShenQi) { builder.AddInt(12, SIdShenQi, -1); }
  public static void AddSIdShenQiShowId(FlatBufferBuilder builder, int SIdShenQiShowId) { builder.AddInt(13, SIdShenQiShowId, -1); }
  public static void AddSBangYuan(FlatBufferBuilder builder, int SBangYuan) { builder.AddInt(14, SBangYuan, 0); }
  public static void AddSBangYin(FlatBufferBuilder builder, int SBangYin) { builder.AddInt(15, SBangYin, 0); }
  public static void AddSIdItemList(FlatBufferBuilder builder, VectorOffset SIdItemListOffset) { builder.AddOffset(16, SIdItemListOffset.Value, 0); }
  public static VectorOffset CreateSIdItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSIdItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSIdItemCountList(FlatBufferBuilder builder, VectorOffset SIdItemCountListOffset) { builder.AddOffset(17, SIdItemCountListOffset.Value, 0); }
  public static VectorOffset CreateSIdItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSIdItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRankBg(FlatBufferBuilder builder, StringOffset RankBgOffset) { builder.AddOffset(18, RankBgOffset.Value, 0); }
  public static void AddRankIcon(FlatBufferBuilder builder, StringOffset RankIconOffset) { builder.AddOffset(19, RankIconOffset.Value, 0); }
  public static Offset<FB_Ladder> EndFB_Ladder(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Ladder>(o);
  }
};

public sealed class FB_LadderContainer : Table {
  public static FB_LadderContainer GetRootAsFB_LadderContainer(ByteBuffer _bb) { return GetRootAsFB_LadderContainer(_bb, new FB_LadderContainer()); }
  public static FB_LadderContainer GetRootAsFB_LadderContainer(ByteBuffer _bb, FB_LadderContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LadderContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LadderContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Ladder GetItems(int j) { return GetItems(new FB_Ladder(), j); }
  public FB_Ladder GetItems(FB_Ladder obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LadderContainer> CreateFB_LadderContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LadderContainer.AddItems(builder, items);
    return FB_LadderContainer.EndFB_LadderContainer(builder);
  }

  public static void StartFB_LadderContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Ladder>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LadderContainer> EndFB_LadderContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LadderContainer>(o);
  }
  public static void FinishFB_LadderContainerBuffer(FlatBufferBuilder builder, Offset<FB_LadderContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
