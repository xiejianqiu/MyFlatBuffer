// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AttrPowerBase : Table {
  public static FB_AttrPowerBase GetRootAsFB_AttrPowerBase(ByteBuffer _bb) { return GetRootAsFB_AttrPowerBase(_bb, new FB_AttrPowerBase()); }
  public static FB_AttrPowerBase GetRootAsFB_AttrPowerBase(ByteBuffer _bb, FB_AttrPowerBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AttrPowerBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float Ratio { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int Model { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsBasePercentAdd { get { int o = __offset(10); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int PowerType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int InitialValue { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_AttrPowerBase> CreateFB_AttrPowerBase(FlatBufferBuilder builder,
      int ID = 0,
      float Ratio = 0,
      int Model = -1,
      bool IsBasePercentAdd = false,
      int PowerType = -1,
      int InitialValue = -1) {
    builder.StartObject(6);
    FB_AttrPowerBase.AddInitialValue(builder, InitialValue);
    FB_AttrPowerBase.AddPowerType(builder, PowerType);
    FB_AttrPowerBase.AddModel(builder, Model);
    FB_AttrPowerBase.AddRatio(builder, Ratio);
    FB_AttrPowerBase.AddID(builder, ID);
    FB_AttrPowerBase.AddIsBasePercentAdd(builder, IsBasePercentAdd);
    return FB_AttrPowerBase.EndFB_AttrPowerBase(builder);
  }

  public static void StartFB_AttrPowerBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRatio(FlatBufferBuilder builder, float Ratio) { builder.AddFloat(1, Ratio, 0); }
  public static void AddModel(FlatBufferBuilder builder, int Model) { builder.AddInt(2, Model, -1); }
  public static void AddIsBasePercentAdd(FlatBufferBuilder builder, bool IsBasePercentAdd) { builder.AddBool(3, IsBasePercentAdd, false); }
  public static void AddPowerType(FlatBufferBuilder builder, int PowerType) { builder.AddInt(4, PowerType, -1); }
  public static void AddInitialValue(FlatBufferBuilder builder, int InitialValue) { builder.AddInt(5, InitialValue, -1); }
  public static Offset<FB_AttrPowerBase> EndFB_AttrPowerBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AttrPowerBase>(o);
  }
};

public sealed class FB_AttrPowerBaseContainer : Table {
  public static FB_AttrPowerBaseContainer GetRootAsFB_AttrPowerBaseContainer(ByteBuffer _bb) { return GetRootAsFB_AttrPowerBaseContainer(_bb, new FB_AttrPowerBaseContainer()); }
  public static FB_AttrPowerBaseContainer GetRootAsFB_AttrPowerBaseContainer(ByteBuffer _bb, FB_AttrPowerBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AttrPowerBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AttrPowerBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AttrPowerBase GetItems(int j) { return GetItems(new FB_AttrPowerBase(), j); }
  public FB_AttrPowerBase GetItems(FB_AttrPowerBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AttrPowerBaseContainer> CreateFB_AttrPowerBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AttrPowerBaseContainer.AddItems(builder, items);
    return FB_AttrPowerBaseContainer.EndFB_AttrPowerBaseContainer(builder);
  }

  public static void StartFB_AttrPowerBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AttrPowerBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AttrPowerBaseContainer> EndFB_AttrPowerBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AttrPowerBaseContainer>(o);
  }
  public static void FinishFB_AttrPowerBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_AttrPowerBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
