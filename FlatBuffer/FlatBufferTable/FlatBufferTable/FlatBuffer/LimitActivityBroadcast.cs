// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LimitActivityBroadcast : Table {
  public static FB_LimitActivityBroadcast GetRootAsFB_LimitActivityBroadcast(ByteBuffer _bb) { return GetRootAsFB_LimitActivityBroadcast(_bb, new FB_LimitActivityBroadcast()); }
  public static FB_LimitActivityBroadcast GetRootAsFB_LimitActivityBroadcast(ByteBuffer _bb, FB_LimitActivityBroadcast obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LimitActivityBroadcast __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string ActivityIcon { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TriggerType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CountDownTime { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TriggerTime { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrDic { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActivityID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string UIName { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Path { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TriggerEndTime { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LimitActivityBroadcast> CreateFB_LimitActivityBroadcast(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset ActivityIcon = default(StringOffset),
      int TriggerType = -1,
      int CountDownTime = -1,
      int TriggerTime = -1,
      int StrDic = -1,
      int ActivityID = -1,
      StringOffset UIName = default(StringOffset),
      StringOffset Path = default(StringOffset),
      int TriggerEndTime = -1) {
    builder.StartObject(10);
    FB_LimitActivityBroadcast.AddTriggerEndTime(builder, TriggerEndTime);
    FB_LimitActivityBroadcast.AddPath(builder, Path);
    FB_LimitActivityBroadcast.AddUIName(builder, UIName);
    FB_LimitActivityBroadcast.AddActivityID(builder, ActivityID);
    FB_LimitActivityBroadcast.AddStrDic(builder, StrDic);
    FB_LimitActivityBroadcast.AddTriggerTime(builder, TriggerTime);
    FB_LimitActivityBroadcast.AddCountDownTime(builder, CountDownTime);
    FB_LimitActivityBroadcast.AddTriggerType(builder, TriggerType);
    FB_LimitActivityBroadcast.AddActivityIcon(builder, ActivityIcon);
    FB_LimitActivityBroadcast.AddID(builder, ID);
    return FB_LimitActivityBroadcast.EndFB_LimitActivityBroadcast(builder);
  }

  public static void StartFB_LimitActivityBroadcast(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActivityIcon(FlatBufferBuilder builder, StringOffset ActivityIconOffset) { builder.AddOffset(1, ActivityIconOffset.Value, 0); }
  public static void AddTriggerType(FlatBufferBuilder builder, int TriggerType) { builder.AddInt(2, TriggerType, -1); }
  public static void AddCountDownTime(FlatBufferBuilder builder, int CountDownTime) { builder.AddInt(3, CountDownTime, -1); }
  public static void AddTriggerTime(FlatBufferBuilder builder, int TriggerTime) { builder.AddInt(4, TriggerTime, -1); }
  public static void AddStrDic(FlatBufferBuilder builder, int StrDic) { builder.AddInt(5, StrDic, -1); }
  public static void AddActivityID(FlatBufferBuilder builder, int ActivityID) { builder.AddInt(6, ActivityID, -1); }
  public static void AddUIName(FlatBufferBuilder builder, StringOffset UINameOffset) { builder.AddOffset(7, UINameOffset.Value, 0); }
  public static void AddPath(FlatBufferBuilder builder, StringOffset PathOffset) { builder.AddOffset(8, PathOffset.Value, 0); }
  public static void AddTriggerEndTime(FlatBufferBuilder builder, int TriggerEndTime) { builder.AddInt(9, TriggerEndTime, -1); }
  public static Offset<FB_LimitActivityBroadcast> EndFB_LimitActivityBroadcast(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LimitActivityBroadcast>(o);
  }
};

public sealed class FB_LimitActivityBroadcastContainer : Table {
  public static FB_LimitActivityBroadcastContainer GetRootAsFB_LimitActivityBroadcastContainer(ByteBuffer _bb) { return GetRootAsFB_LimitActivityBroadcastContainer(_bb, new FB_LimitActivityBroadcastContainer()); }
  public static FB_LimitActivityBroadcastContainer GetRootAsFB_LimitActivityBroadcastContainer(ByteBuffer _bb, FB_LimitActivityBroadcastContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LimitActivityBroadcastContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LimitActivityBroadcastContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LimitActivityBroadcast GetItems(int j) { return GetItems(new FB_LimitActivityBroadcast(), j); }
  public FB_LimitActivityBroadcast GetItems(FB_LimitActivityBroadcast obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LimitActivityBroadcastContainer> CreateFB_LimitActivityBroadcastContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LimitActivityBroadcastContainer.AddItems(builder, items);
    return FB_LimitActivityBroadcastContainer.EndFB_LimitActivityBroadcastContainer(builder);
  }

  public static void StartFB_LimitActivityBroadcastContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LimitActivityBroadcast>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LimitActivityBroadcastContainer> EndFB_LimitActivityBroadcastContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LimitActivityBroadcastContainer>(o);
  }
  public static void FinishFB_LimitActivityBroadcastContainerBuffer(FlatBufferBuilder builder, Offset<FB_LimitActivityBroadcastContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
