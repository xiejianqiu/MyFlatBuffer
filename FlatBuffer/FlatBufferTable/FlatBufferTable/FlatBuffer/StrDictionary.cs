// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StrDictionary : Table {
  public static FB_StrDictionary GetRootAsFB_StrDictionary(ByteBuffer _bb) { return GetRootAsFB_StrDictionary(_bb, new FB_StrDictionary()); }
  public static FB_StrDictionary GetRootAsFB_StrDictionary(ByteBuffer _bb, FB_StrDictionary obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StrDictionary __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string StrDictionary { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_StrDictionary> CreateFB_StrDictionary(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset StrDictionary = default(StringOffset)) {
    builder.StartObject(2);
    FB_StrDictionary.AddStrDictionary(builder, StrDictionary);
    FB_StrDictionary.AddId(builder, Id);
    return FB_StrDictionary.EndFB_StrDictionary(builder);
  }

  public static void StartFB_StrDictionary(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStrDictionary(FlatBufferBuilder builder, StringOffset StrDictionaryOffset) { builder.AddOffset(1, StrDictionaryOffset.Value, 0); }
  public static Offset<FB_StrDictionary> EndFB_StrDictionary(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrDictionary>(o);
  }
};

public sealed class FB_StrDictionaryContainer : Table {
  public static FB_StrDictionaryContainer GetRootAsFB_StrDictionaryContainer(ByteBuffer _bb) { return GetRootAsFB_StrDictionaryContainer(_bb, new FB_StrDictionaryContainer()); }
  public static FB_StrDictionaryContainer GetRootAsFB_StrDictionaryContainer(ByteBuffer _bb, FB_StrDictionaryContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StrDictionaryContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StrDictionaryContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StrDictionary GetItems(int j) { return GetItems(new FB_StrDictionary(), j); }
  public FB_StrDictionary GetItems(FB_StrDictionary obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrDictionaryContainer> CreateFB_StrDictionaryContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StrDictionaryContainer.AddItems(builder, items);
    return FB_StrDictionaryContainer.EndFB_StrDictionaryContainer(builder);
  }

  public static void StartFB_StrDictionaryContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StrDictionary>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrDictionaryContainer> EndFB_StrDictionaryContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrDictionaryContainer>(o);
  }
  public static void FinishFB_StrDictionaryContainerBuffer(FlatBufferBuilder builder, Offset<FB_StrDictionaryContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
