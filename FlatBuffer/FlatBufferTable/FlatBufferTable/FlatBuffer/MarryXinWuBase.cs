// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryXinWuBase : Table {
  public static FB_MarryXinWuBase GetRootAsFB_MarryXinWuBase(ByteBuffer _bb) { return GetRootAsFB_MarryXinWuBase(_bb, new FB_MarryXinWuBase()); }
  public static FB_MarryXinWuBase GetRootAsFB_MarryXinWuBase(ByteBuffer _bb, FB_MarryXinWuBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryXinWuBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Level { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Step { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Exp { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayItemID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int QuickItemCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSpecAttrIDList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpecAttrIDListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSpectAttrValueList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpectAttrValueListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryXinWuBase> CreateFB_MarryXinWuBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Level = -1,
      int Step = -1,
      int Exp = -1,
      int PayItemID = -1,
      int QuickItemCount = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset SpecAttrIDList = default(VectorOffset),
      VectorOffset SpectAttrValueList = default(VectorOffset)) {
    builder.StartObject(11);
    FB_MarryXinWuBase.AddSpectAttrValueList(builder, SpectAttrValueList);
    FB_MarryXinWuBase.AddSpecAttrIDList(builder, SpecAttrIDList);
    FB_MarryXinWuBase.AddAttrValueList(builder, AttrValueList);
    FB_MarryXinWuBase.AddAttrIDList(builder, AttrIDList);
    FB_MarryXinWuBase.AddQuickItemCount(builder, QuickItemCount);
    FB_MarryXinWuBase.AddPayItemID(builder, PayItemID);
    FB_MarryXinWuBase.AddExp(builder, Exp);
    FB_MarryXinWuBase.AddStep(builder, Step);
    FB_MarryXinWuBase.AddLevel(builder, Level);
    FB_MarryXinWuBase.AddName(builder, Name);
    FB_MarryXinWuBase.AddID(builder, ID);
    return FB_MarryXinWuBase.EndFB_MarryXinWuBase(builder);
  }

  public static void StartFB_MarryXinWuBase(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, -1); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(3, Step, -1); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(4, Exp, -1); }
  public static void AddPayItemID(FlatBufferBuilder builder, int PayItemID) { builder.AddInt(5, PayItemID, -1); }
  public static void AddQuickItemCount(FlatBufferBuilder builder, int QuickItemCount) { builder.AddInt(6, QuickItemCount, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(7, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(8, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpecAttrIDList(FlatBufferBuilder builder, VectorOffset SpecAttrIDListOffset) { builder.AddOffset(9, SpecAttrIDListOffset.Value, 0); }
  public static VectorOffset CreateSpecAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpecAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpectAttrValueList(FlatBufferBuilder builder, VectorOffset SpectAttrValueListOffset) { builder.AddOffset(10, SpectAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateSpectAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpectAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryXinWuBase> EndFB_MarryXinWuBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryXinWuBase>(o);
  }
};

public sealed class FB_MarryXinWuBaseContainer : Table {
  public static FB_MarryXinWuBaseContainer GetRootAsFB_MarryXinWuBaseContainer(ByteBuffer _bb) { return GetRootAsFB_MarryXinWuBaseContainer(_bb, new FB_MarryXinWuBaseContainer()); }
  public static FB_MarryXinWuBaseContainer GetRootAsFB_MarryXinWuBaseContainer(ByteBuffer _bb, FB_MarryXinWuBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryXinWuBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryXinWuBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryXinWuBase GetItems(int j) { return GetItems(new FB_MarryXinWuBase(), j); }
  public FB_MarryXinWuBase GetItems(FB_MarryXinWuBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryXinWuBaseContainer> CreateFB_MarryXinWuBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryXinWuBaseContainer.AddItems(builder, items);
    return FB_MarryXinWuBaseContainer.EndFB_MarryXinWuBaseContainer(builder);
  }

  public static void StartFB_MarryXinWuBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryXinWuBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryXinWuBaseContainer> EndFB_MarryXinWuBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryXinWuBaseContainer>(o);
  }
  public static void FinishFB_MarryXinWuBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryXinWuBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
