// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LocalNotification : Table {
  public static FB_LocalNotification GetRootAsFB_LocalNotification(ByteBuffer _bb) { return GetRootAsFB_LocalNotification(_bb, new FB_LocalNotification()); }
  public static FB_LocalNotification GetRootAsFB_LocalNotification(ByteBuffer _bb, FB_LocalNotification obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LocalNotification __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Indentifier { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TimeType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TimeValue { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Notification { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_LocalNotification> CreateFB_LocalNotification(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Indentifier = default(StringOffset),
      int TimeType = -1,
      int TimeValue = -1,
      StringOffset Notification = default(StringOffset)) {
    builder.StartObject(5);
    FB_LocalNotification.AddNotification(builder, Notification);
    FB_LocalNotification.AddTimeValue(builder, TimeValue);
    FB_LocalNotification.AddTimeType(builder, TimeType);
    FB_LocalNotification.AddIndentifier(builder, Indentifier);
    FB_LocalNotification.AddId(builder, Id);
    return FB_LocalNotification.EndFB_LocalNotification(builder);
  }

  public static void StartFB_LocalNotification(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddIndentifier(FlatBufferBuilder builder, StringOffset IndentifierOffset) { builder.AddOffset(1, IndentifierOffset.Value, 0); }
  public static void AddTimeType(FlatBufferBuilder builder, int TimeType) { builder.AddInt(2, TimeType, -1); }
  public static void AddTimeValue(FlatBufferBuilder builder, int TimeValue) { builder.AddInt(3, TimeValue, -1); }
  public static void AddNotification(FlatBufferBuilder builder, StringOffset NotificationOffset) { builder.AddOffset(4, NotificationOffset.Value, 0); }
  public static Offset<FB_LocalNotification> EndFB_LocalNotification(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LocalNotification>(o);
  }
};

public sealed class FB_LocalNotificationContainer : Table {
  public static FB_LocalNotificationContainer GetRootAsFB_LocalNotificationContainer(ByteBuffer _bb) { return GetRootAsFB_LocalNotificationContainer(_bb, new FB_LocalNotificationContainer()); }
  public static FB_LocalNotificationContainer GetRootAsFB_LocalNotificationContainer(ByteBuffer _bb, FB_LocalNotificationContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LocalNotificationContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LocalNotificationContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LocalNotification GetItems(int j) { return GetItems(new FB_LocalNotification(), j); }
  public FB_LocalNotification GetItems(FB_LocalNotification obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LocalNotificationContainer> CreateFB_LocalNotificationContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LocalNotificationContainer.AddItems(builder, items);
    return FB_LocalNotificationContainer.EndFB_LocalNotificationContainer(builder);
  }

  public static void StartFB_LocalNotificationContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LocalNotification>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LocalNotificationContainer> EndFB_LocalNotificationContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LocalNotificationContainer>(o);
  }
  public static void FinishFB_LocalNotificationContainerBuffer(FlatBufferBuilder builder, Offset<FB_LocalNotificationContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
