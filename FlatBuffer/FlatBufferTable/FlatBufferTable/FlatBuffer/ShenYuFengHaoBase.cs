// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenYuFengHaoBase : Table {
  public static FB_ShenYuFengHaoBase GetRootAsFB_ShenYuFengHaoBase(ByteBuffer _bb) { return GetRootAsFB_ShenYuFengHaoBase(_bb, new FB_ShenYuFengHaoBase()); }
  public static FB_ShenYuFengHaoBase GetRootAsFB_ShenYuFengHaoBase(ByteBuffer _bb, FB_ShenYuFengHaoBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenYuFengHaoBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int SceneID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Point { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxDayPoint { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SingleSeasionTitleId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DoubleSeasionTitleId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWinItemIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WinItemIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWinItemCountList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WinItemCountListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLoseItemIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LoseItemIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetLoseItemCountList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LoseItemCountListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetScoreItemIdList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ScoreItemIdListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetScoreItemCountList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ScoreItemCountListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int Discount { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)10; } }
  public int GetSecondItemIdList(int j) { int o = __offset(30); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SecondItemIdListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSecondItemCountList(int j) { int o = __offset(32); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SecondItemCountListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenYuFengHaoBase> CreateFB_ShenYuFengHaoBase(FlatBufferBuilder builder,
      int SceneID = 0,
      StringOffset Name = default(StringOffset),
      int Point = -1,
      int MaxDayPoint = -1,
      int SingleSeasionTitleId = -1,
      int DoubleSeasionTitleId = -1,
      VectorOffset WinItemIdList = default(VectorOffset),
      VectorOffset WinItemCountList = default(VectorOffset),
      VectorOffset LoseItemIdList = default(VectorOffset),
      VectorOffset LoseItemCountList = default(VectorOffset),
      VectorOffset ScoreItemIdList = default(VectorOffset),
      VectorOffset ScoreItemCountList = default(VectorOffset),
      int Discount = 10,
      VectorOffset SecondItemIdList = default(VectorOffset),
      VectorOffset SecondItemCountList = default(VectorOffset)) {
    builder.StartObject(15);
    FB_ShenYuFengHaoBase.AddSecondItemCountList(builder, SecondItemCountList);
    FB_ShenYuFengHaoBase.AddSecondItemIdList(builder, SecondItemIdList);
    FB_ShenYuFengHaoBase.AddDiscount(builder, Discount);
    FB_ShenYuFengHaoBase.AddScoreItemCountList(builder, ScoreItemCountList);
    FB_ShenYuFengHaoBase.AddScoreItemIdList(builder, ScoreItemIdList);
    FB_ShenYuFengHaoBase.AddLoseItemCountList(builder, LoseItemCountList);
    FB_ShenYuFengHaoBase.AddLoseItemIdList(builder, LoseItemIdList);
    FB_ShenYuFengHaoBase.AddWinItemCountList(builder, WinItemCountList);
    FB_ShenYuFengHaoBase.AddWinItemIdList(builder, WinItemIdList);
    FB_ShenYuFengHaoBase.AddDoubleSeasionTitleId(builder, DoubleSeasionTitleId);
    FB_ShenYuFengHaoBase.AddSingleSeasionTitleId(builder, SingleSeasionTitleId);
    FB_ShenYuFengHaoBase.AddMaxDayPoint(builder, MaxDayPoint);
    FB_ShenYuFengHaoBase.AddPoint(builder, Point);
    FB_ShenYuFengHaoBase.AddName(builder, Name);
    FB_ShenYuFengHaoBase.AddSceneID(builder, SceneID);
    return FB_ShenYuFengHaoBase.EndFB_ShenYuFengHaoBase(builder);
  }

  public static void StartFB_ShenYuFengHaoBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(0, SceneID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPoint(FlatBufferBuilder builder, int Point) { builder.AddInt(2, Point, -1); }
  public static void AddMaxDayPoint(FlatBufferBuilder builder, int MaxDayPoint) { builder.AddInt(3, MaxDayPoint, -1); }
  public static void AddSingleSeasionTitleId(FlatBufferBuilder builder, int SingleSeasionTitleId) { builder.AddInt(4, SingleSeasionTitleId, -1); }
  public static void AddDoubleSeasionTitleId(FlatBufferBuilder builder, int DoubleSeasionTitleId) { builder.AddInt(5, DoubleSeasionTitleId, -1); }
  public static void AddWinItemIdList(FlatBufferBuilder builder, VectorOffset WinItemIdListOffset) { builder.AddOffset(6, WinItemIdListOffset.Value, 0); }
  public static VectorOffset CreateWinItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWinItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWinItemCountList(FlatBufferBuilder builder, VectorOffset WinItemCountListOffset) { builder.AddOffset(7, WinItemCountListOffset.Value, 0); }
  public static VectorOffset CreateWinItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWinItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLoseItemIdList(FlatBufferBuilder builder, VectorOffset LoseItemIdListOffset) { builder.AddOffset(8, LoseItemIdListOffset.Value, 0); }
  public static VectorOffset CreateLoseItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLoseItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLoseItemCountList(FlatBufferBuilder builder, VectorOffset LoseItemCountListOffset) { builder.AddOffset(9, LoseItemCountListOffset.Value, 0); }
  public static VectorOffset CreateLoseItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLoseItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddScoreItemIdList(FlatBufferBuilder builder, VectorOffset ScoreItemIdListOffset) { builder.AddOffset(10, ScoreItemIdListOffset.Value, 0); }
  public static VectorOffset CreateScoreItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartScoreItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddScoreItemCountList(FlatBufferBuilder builder, VectorOffset ScoreItemCountListOffset) { builder.AddOffset(11, ScoreItemCountListOffset.Value, 0); }
  public static VectorOffset CreateScoreItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartScoreItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDiscount(FlatBufferBuilder builder, int Discount) { builder.AddInt(12, Discount, 10); }
  public static void AddSecondItemIdList(FlatBufferBuilder builder, VectorOffset SecondItemIdListOffset) { builder.AddOffset(13, SecondItemIdListOffset.Value, 0); }
  public static VectorOffset CreateSecondItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSecondItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSecondItemCountList(FlatBufferBuilder builder, VectorOffset SecondItemCountListOffset) { builder.AddOffset(14, SecondItemCountListOffset.Value, 0); }
  public static VectorOffset CreateSecondItemCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSecondItemCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenYuFengHaoBase> EndFB_ShenYuFengHaoBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenYuFengHaoBase>(o);
  }
};

public sealed class FB_ShenYuFengHaoBaseContainer : Table {
  public static FB_ShenYuFengHaoBaseContainer GetRootAsFB_ShenYuFengHaoBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShenYuFengHaoBaseContainer(_bb, new FB_ShenYuFengHaoBaseContainer()); }
  public static FB_ShenYuFengHaoBaseContainer GetRootAsFB_ShenYuFengHaoBaseContainer(ByteBuffer _bb, FB_ShenYuFengHaoBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenYuFengHaoBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenYuFengHaoBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenYuFengHaoBase GetItems(int j) { return GetItems(new FB_ShenYuFengHaoBase(), j); }
  public FB_ShenYuFengHaoBase GetItems(FB_ShenYuFengHaoBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenYuFengHaoBaseContainer> CreateFB_ShenYuFengHaoBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenYuFengHaoBaseContainer.AddItems(builder, items);
    return FB_ShenYuFengHaoBaseContainer.EndFB_ShenYuFengHaoBaseContainer(builder);
  }

  public static void StartFB_ShenYuFengHaoBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenYuFengHaoBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenYuFengHaoBaseContainer> EndFB_ShenYuFengHaoBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenYuFengHaoBaseContainer>(o);
  }
  public static void FinishFB_ShenYuFengHaoBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenYuFengHaoBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
