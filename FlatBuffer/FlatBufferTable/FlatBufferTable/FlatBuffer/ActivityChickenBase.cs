// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityChickenBase : Table {
  public static FB_ActivityChickenBase GetRootAsFB_ActivityChickenBase(ByteBuffer _bb) { return GetRootAsFB_ActivityChickenBase(_bb, new FB_ActivityChickenBase()); }
  public static FB_ActivityChickenBase GetRootAsFB_ActivityChickenBase(ByteBuffer _bb, FB_ActivityChickenBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityChickenBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LevelLimit { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityDesc { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JoinCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OpenType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenTime { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EndTime { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ChickenNum { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EagleNum { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int VictoryMail { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FailMail { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DurationTime { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityChickenBase> CreateFB_ActivityChickenBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int LevelLimit = -1,
      int CopySceneID = -1,
      int ActivityDesc = -1,
      int ActivityId = -1,
      int JoinCount = 0,
      int OpenType = -1,
      int OpenTime = -1,
      int EndTime = -1,
      int ChickenNum = 0,
      int EagleNum = 0,
      int VictoryMail = 0,
      int FailMail = 0,
      int DurationTime = -1) {
    builder.StartObject(15);
    FB_ActivityChickenBase.AddDurationTime(builder, DurationTime);
    FB_ActivityChickenBase.AddFailMail(builder, FailMail);
    FB_ActivityChickenBase.AddVictoryMail(builder, VictoryMail);
    FB_ActivityChickenBase.AddEagleNum(builder, EagleNum);
    FB_ActivityChickenBase.AddChickenNum(builder, ChickenNum);
    FB_ActivityChickenBase.AddEndTime(builder, EndTime);
    FB_ActivityChickenBase.AddOpenTime(builder, OpenTime);
    FB_ActivityChickenBase.AddOpenType(builder, OpenType);
    FB_ActivityChickenBase.AddJoinCount(builder, JoinCount);
    FB_ActivityChickenBase.AddActivityId(builder, ActivityId);
    FB_ActivityChickenBase.AddActivityDesc(builder, ActivityDesc);
    FB_ActivityChickenBase.AddCopySceneID(builder, CopySceneID);
    FB_ActivityChickenBase.AddLevelLimit(builder, LevelLimit);
    FB_ActivityChickenBase.AddName(builder, Name);
    FB_ActivityChickenBase.AddID(builder, ID);
    return FB_ActivityChickenBase.EndFB_ActivityChickenBase(builder);
  }

  public static void StartFB_ActivityChickenBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(2, LevelLimit, -1); }
  public static void AddCopySceneID(FlatBufferBuilder builder, int CopySceneID) { builder.AddInt(3, CopySceneID, -1); }
  public static void AddActivityDesc(FlatBufferBuilder builder, int ActivityDesc) { builder.AddInt(4, ActivityDesc, -1); }
  public static void AddActivityId(FlatBufferBuilder builder, int ActivityId) { builder.AddInt(5, ActivityId, -1); }
  public static void AddJoinCount(FlatBufferBuilder builder, int JoinCount) { builder.AddInt(6, JoinCount, 0); }
  public static void AddOpenType(FlatBufferBuilder builder, int OpenType) { builder.AddInt(7, OpenType, -1); }
  public static void AddOpenTime(FlatBufferBuilder builder, int OpenTime) { builder.AddInt(8, OpenTime, -1); }
  public static void AddEndTime(FlatBufferBuilder builder, int EndTime) { builder.AddInt(9, EndTime, -1); }
  public static void AddChickenNum(FlatBufferBuilder builder, int ChickenNum) { builder.AddInt(10, ChickenNum, 0); }
  public static void AddEagleNum(FlatBufferBuilder builder, int EagleNum) { builder.AddInt(11, EagleNum, 0); }
  public static void AddVictoryMail(FlatBufferBuilder builder, int VictoryMail) { builder.AddInt(12, VictoryMail, 0); }
  public static void AddFailMail(FlatBufferBuilder builder, int FailMail) { builder.AddInt(13, FailMail, 0); }
  public static void AddDurationTime(FlatBufferBuilder builder, int DurationTime) { builder.AddInt(14, DurationTime, -1); }
  public static Offset<FB_ActivityChickenBase> EndFB_ActivityChickenBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityChickenBase>(o);
  }
};

public sealed class FB_ActivityChickenBaseContainer : Table {
  public static FB_ActivityChickenBaseContainer GetRootAsFB_ActivityChickenBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityChickenBaseContainer(_bb, new FB_ActivityChickenBaseContainer()); }
  public static FB_ActivityChickenBaseContainer GetRootAsFB_ActivityChickenBaseContainer(ByteBuffer _bb, FB_ActivityChickenBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityChickenBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityChickenBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityChickenBase GetItems(int j) { return GetItems(new FB_ActivityChickenBase(), j); }
  public FB_ActivityChickenBase GetItems(FB_ActivityChickenBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityChickenBaseContainer> CreateFB_ActivityChickenBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityChickenBaseContainer.AddItems(builder, items);
    return FB_ActivityChickenBaseContainer.EndFB_ActivityChickenBaseContainer(builder);
  }

  public static void StartFB_ActivityChickenBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityChickenBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityChickenBaseContainer> EndFB_ActivityChickenBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityChickenBaseContainer>(o);
  }
  public static void FinishFB_ActivityChickenBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityChickenBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
