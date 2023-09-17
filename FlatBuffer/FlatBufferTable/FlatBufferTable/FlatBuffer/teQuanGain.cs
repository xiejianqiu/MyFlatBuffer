// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_teQuanGain : Table {
  public static FB_teQuanGain GetRootAsFB_teQuanGain(ByteBuffer _bb) { return GetRootAsFB_teQuanGain(_bb, new FB_teQuanGain()); }
  public static FB_teQuanGain GetRootAsFB_teQuanGain(ByteBuffer _bb, FB_teQuanGain obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_teQuanGain __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetTeQuanIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TeQuanIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int Cd { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Related { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAdvanceRmbIdList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AdvanceRmbIdListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int StrDictionaryID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_teQuanGain> CreateFB_teQuanGain(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset teQuanIdList = default(VectorOffset),
      int cd = -1,
      int related = -1,
      VectorOffset advanceRmbIdList = default(VectorOffset),
      int StrDictionaryID = -1) {
    builder.StartObject(7);
    FB_teQuanGain.AddStrDictionaryID(builder, StrDictionaryID);
    FB_teQuanGain.AddAdvanceRmbIdList(builder, advanceRmbIdList);
    FB_teQuanGain.AddRelated(builder, related);
    FB_teQuanGain.AddCd(builder, cd);
    FB_teQuanGain.AddTeQuanIdList(builder, teQuanIdList);
    FB_teQuanGain.AddName(builder, Name);
    FB_teQuanGain.AddId(builder, Id);
    return FB_teQuanGain.EndFB_teQuanGain(builder);
  }

  public static void StartFB_teQuanGain(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTeQuanIdList(FlatBufferBuilder builder, VectorOffset teQuanIdListOffset) { builder.AddOffset(2, teQuanIdListOffset.Value, 0); }
  public static VectorOffset CreateTeQuanIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTeQuanIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCd(FlatBufferBuilder builder, int cd) { builder.AddInt(3, cd, -1); }
  public static void AddRelated(FlatBufferBuilder builder, int related) { builder.AddInt(4, related, -1); }
  public static void AddAdvanceRmbIdList(FlatBufferBuilder builder, VectorOffset advanceRmbIdListOffset) { builder.AddOffset(5, advanceRmbIdListOffset.Value, 0); }
  public static VectorOffset CreateAdvanceRmbIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAdvanceRmbIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStrDictionaryID(FlatBufferBuilder builder, int StrDictionaryID) { builder.AddInt(6, StrDictionaryID, -1); }
  public static Offset<FB_teQuanGain> EndFB_teQuanGain(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_teQuanGain>(o);
  }
};

public sealed class FB_teQuanGainContainer : Table {
  public static FB_teQuanGainContainer GetRootAsFB_teQuanGainContainer(ByteBuffer _bb) { return GetRootAsFB_teQuanGainContainer(_bb, new FB_teQuanGainContainer()); }
  public static FB_teQuanGainContainer GetRootAsFB_teQuanGainContainer(ByteBuffer _bb, FB_teQuanGainContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_teQuanGainContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_teQuanGainContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_teQuanGain GetItems(int j) { return GetItems(new FB_teQuanGain(), j); }
  public FB_teQuanGain GetItems(FB_teQuanGain obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_teQuanGainContainer> CreateFB_teQuanGainContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_teQuanGainContainer.AddItems(builder, items);
    return FB_teQuanGainContainer.EndFB_teQuanGainContainer(builder);
  }

  public static void StartFB_teQuanGainContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_teQuanGain>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_teQuanGainContainer> EndFB_teQuanGainContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_teQuanGainContainer>(o);
  }
  public static void FinishFB_teQuanGainContainerBuffer(FlatBufferBuilder builder, Offset<FB_teQuanGainContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
