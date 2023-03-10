// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ProgressBase : Table {
  public static FB_ProgressBase GetRootAsFB_ProgressBase(ByteBuffer _bb) { return GetRootAsFB_ProgressBase(_bb, new FB_ProgressBase()); }
  public static FB_ProgressBase GetRootAsFB_ProgressBase(ByteBuffer _bb, FB_ProgressBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ProgressBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Duration { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Text { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int AnimationID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool CanDamageInterrupt { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_ProgressBase> CreateFB_ProgressBase(FlatBufferBuilder builder,
      int ID = 0,
      int Duration = -1,
      StringOffset Text = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int AnimationID = -1,
      bool CanDamageInterrupt = false) {
    builder.StartObject(6);
    FB_ProgressBase.AddAnimationID(builder, AnimationID);
    FB_ProgressBase.AddIcon(builder, Icon);
    FB_ProgressBase.AddText(builder, Text);
    FB_ProgressBase.AddDuration(builder, Duration);
    FB_ProgressBase.AddID(builder, ID);
    FB_ProgressBase.AddCanDamageInterrupt(builder, CanDamageInterrupt);
    return FB_ProgressBase.EndFB_ProgressBase(builder);
  }

  public static void StartFB_ProgressBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDuration(FlatBufferBuilder builder, int Duration) { builder.AddInt(1, Duration, -1); }
  public static void AddText(FlatBufferBuilder builder, StringOffset TextOffset) { builder.AddOffset(2, TextOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(3, IconOffset.Value, 0); }
  public static void AddAnimationID(FlatBufferBuilder builder, int AnimationID) { builder.AddInt(4, AnimationID, -1); }
  public static void AddCanDamageInterrupt(FlatBufferBuilder builder, bool CanDamageInterrupt) { builder.AddBool(5, CanDamageInterrupt, false); }
  public static Offset<FB_ProgressBase> EndFB_ProgressBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ProgressBase>(o);
  }
};

public sealed class FB_ProgressBaseContainer : Table {
  public static FB_ProgressBaseContainer GetRootAsFB_ProgressBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ProgressBaseContainer(_bb, new FB_ProgressBaseContainer()); }
  public static FB_ProgressBaseContainer GetRootAsFB_ProgressBaseContainer(ByteBuffer _bb, FB_ProgressBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ProgressBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ProgressBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ProgressBase GetItems(int j) { return GetItems(new FB_ProgressBase(), j); }
  public FB_ProgressBase GetItems(FB_ProgressBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ProgressBaseContainer> CreateFB_ProgressBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ProgressBaseContainer.AddItems(builder, items);
    return FB_ProgressBaseContainer.EndFB_ProgressBaseContainer(builder);
  }

  public static void StartFB_ProgressBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ProgressBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ProgressBaseContainer> EndFB_ProgressBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ProgressBaseContainer>(o);
  }
  public static void FinishFB_ProgressBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ProgressBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
